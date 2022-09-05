## Setup
```
node --version

npm --version

npm i @angular/cli -g

ng --version
```


## Create Angular project named 'client'
```
cd <ASP.NET Proj>

ng new client --skip-git --skip-tets --minimal --defaults   


```

## Integrate with ASP.NET project
```
// modify angular.json

"outputPath": "../wwwroot/client"
```

Modify Views/App/  *.cshtml
```
@section Scripts {
  <script src="~/client/vendor.js"></script>
  <script src="~/client/polyfills.js"></script>
  <script src="~/client/runtime.js"></script>
  <script src="~/client/main.js" asp-append-version="true"></script>
}
@section head {
  <link href="~/client/styles.css" rel="stylesheet" />
}
<the-shop></the-shop>
```