import { Component } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
/** test component*/
export class TestComponent {
  text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sodales eros id accumsan dignissim. Sed ac ultrices purus. Etiam a justo vitae quam tincidunt iaculis. In commodo, ligula a vulputate fermentum, ligula nulla fringilla sem, non fringilla erat ante quis risus. Nunc bibendum, purus at vulputate sodales, augue ipsum posuere.";
  isFavorite = false;
  constructor() {

  }

  onFavoriteClick() {
    this.isFavorite = !this.isFavorite;
  }
}
