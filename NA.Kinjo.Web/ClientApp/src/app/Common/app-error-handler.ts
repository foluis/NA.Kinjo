import { ErrorHandler } from "@angular/core";

export class AppErrorHandler implements ErrorHandler {
  handleError(error: any): void {
    alert("An unexpected error ocurred :)");//Toas notification
    console.log(error);//log error on server
  }

}
