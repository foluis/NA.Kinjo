import { Component, OnInit } from '@angular/core';
import { AppError } from '../../Common/app-error';
import { BadInputError } from '../../Common/bad-input-error';
import { NotFoundError } from '../../Common/not-found-error';
import { PostService } from '../../services/post.service';


@Component({
  selector: 'post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})

export class PostComponent implements OnInit {

  posts: any[];

  constructor(private service: PostService) { }

  ngOnInit(): void {
    this.service.getAll()
      .subscribe(
        posts => this.posts = posts
        //  posts => {
        //    this.posts = posts;
        //}
      );
  }

  createPost(input: HTMLInputElement) {
    let post = { title: input.value }
    this.posts.splice(0, 0, post);

    input.value = '';

    this.service.create(JSON.stringify(post))
      .subscribe(
        newPost => {
          post['id'] = newPost.id;
        },
        (error: AppError) => {
          this.posts.splice(0, 1);

          if (error instanceof BadInputError) {
            alert("Error 400");
          }
          else {
            throw error;
          }
        });
  }

  updatePost(post) {
    this.service.update(post)
      .subscribe(
        updatedPost => {
          console.log(updatedPost);
        });
  }

  deletePost(post) {
    let index = this.posts.indexOf(post);
    this.posts.splice(index, 1);

    this.service.delete(post.id)
      .subscribe(
        null,
        (error: AppError) => {
          this.posts.splice(index, 0, post);

          if (error instanceof NotFoundError) {
            alert("This post has been already deleted");
          }
          else throw error;
        });
  }
}
