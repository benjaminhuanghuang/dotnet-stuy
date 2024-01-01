


## Move Villa List to Partial View.


## Partial refresh
wwwroot -> Add -> Client-side library -> Provider = cdnjs ->  jquery-ajax-unobtrusive -> Install

```
<script src="~/jquery-ajax-unobtrusive/jquery.unobtrusive-ajax.js"></script>
```


```
  return PartialView("_VillaList", homeVM);
```


```
    <form method="post" asp-action="GetVillasByDate"  data-ajax-method="post" data-ajax="true" data-ajax-mode="replace"
        data-ajax-update="#VillasList">
```


## Partial refresh Method2 : without jquery.unobtrusive-ajax.js
Remove
```
data-ajax-method="post" data-ajax="true"
          data-ajax-mode="replace" data-ajax-update="#VillasList"
```

```
onclick="fnLoadVillaList()"
```

## Spinner
Add wwwroot/css/spinner.css

Add div into _Layout.cshtml
```
  <div class="loading spinner" style="display:none;"></div>
```


```
   $('.spinner').show();
```
