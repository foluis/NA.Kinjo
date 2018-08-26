import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { AppError } from '../Common/app-error';
import { BadInputError } from '../Common/bad-input-error';
import { NotFoundError } from '../Common/not-found-error';

@Injectable()
export class DataService {

  constructor(private url: string, private http: HttpClient) { }

  getAll() {
    return this.http.get(this.url)
      .map(response => response as any[])
      .catch(this.handleError);
  }

  create(resource) {
    return this.http.post(this.url, JSON.stringify(resource))
      .map(response => response as any)
      .catch(this.handleError);
  }

  update(resource) {
    return this.http.patch(this.url + '/' + resource.id, JSON.stringify({ isRead: true }))
      .map(response => response as any)
      .catch(this.handleError);
  }

  delete(id) {    
    return this.http.delete(this.url + '/' + id)
      .map(response => response as any)
      .catch(this.handleError);
  }

  private handleError(error: Response) {
    if (error.status === 400)
      return Observable.throw(new BadInputError(error.json()));
    if (error.status === 404)
      return Observable.throw(new NotFoundError());

    return Observable.throw(new AppError(error.json()));
  }
}
