```bash

ng new client

## tailwindcss website -> get started -> framework guides -> angular
npm i -D tailwindcss postcss autoprefixer
npx tailwindcss init
```

Install tailwind CSS Intellisense extension in VSCode


## Create a new component

```bash
ng g c students --standalone

ng g s services/students

ng g c students/student-form
```


## Notification

```bash
npm i ngx-toastr
```

app.config.ts
```ts
export const appConfig: ApplicationConfig = {
  providers: [
    providerToasts(),
  ]
};
```

styles.scss
```scss
@import 'ngx-toastr/toastr.css';
```
