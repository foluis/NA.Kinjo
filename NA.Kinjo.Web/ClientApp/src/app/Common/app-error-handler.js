"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var AppErrorHandler = /** @class */ (function () {
    function AppErrorHandler() {
    }
    AppErrorHandler.prototype.handleError = function (error) {
        alert("An unexpected error ocurred :)"); //Toas notification
        console.log(error); //log error on server
    };
    return AppErrorHandler;
}());
exports.AppErrorHandler = AppErrorHandler;
//# sourceMappingURL=app-error-handler.js.map