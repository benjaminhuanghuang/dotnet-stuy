## Syncfusion
Install Syncfusion.DocIO.Net.Core

appsettings.json
```json
"Syncfusion": {
"Licensekey": "Mgo+DSMBMAY9C3t2V1hhQLJAfV5AQmBIYVp/TGpJfl96cVx™ZVVBJAtUQF1hSn5bd®F¡Wn1Zc3RQTmFd™
}
```

Program.cs
```cs
SyncfusionLicenseProvider.RegisterLicense(builder.Configuration["Syncfusion:License"]).Get<string>();

```


BookingDetails.cshtml
```html

    <form method="post">
        <div class="row pt-1 mb-3 " style="border-radius:20px; ">
            <div class="col-12 text-center">

                <button asp-action="GenerateInvoice" asp-route-id="@Model.Id"
                asp-route-downloadType="word" type="submit"
                        class="btn btn-sm btn-secondary my-1">
                    <i class="bi bi-file-earmark-word"></i> Generate Invoice (word)
                </button>
                
                <button asp-action="GenerateInvoice" asp-route-id="@Model.Id"
                        asp-route-downloadType="pdf"  type="submit"
                                    class="btn btn-sm btn-secondary my-1">
                    <i class="bi bi-file-earmark-pdf"></i> Generate Invoice (pdf)
                </button>

            </div>
        </div>
    </form>
```

BookingController.cs
```cs
[HttpPost]
[Authorize]
public IActionResult GenerateInvoice(int id, string downloadType)
{

}
```


## Export pdf
