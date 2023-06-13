# Build a Blog Using ASP.NET Core, Angular 14, and SQL Server
https://learning.oreilly.com/videos/build-a-blog/9781801073271/


## Ch2: Setup
Server side:
ASP.NET Core web Application

Client side
```
cd BlogLab

ng new BlogLab-UI

cd BlogLab-UI
npm install ngx-bootstrap@latest --legacy-peer-deps
npm i @fortawesome/fontawesome-free
```

Add css in angular.json
```
"styles": [
    " . /node_modules/bootstrap/dist/css/bootstrap.min.css",
    "./ node_modules/ngx-bootstrap/datepicker/bs-datepicker.css",
    "src/styles.css",
    "/node_modules/@fortawesome/fontawesome-free/css/all.css"
],
```
