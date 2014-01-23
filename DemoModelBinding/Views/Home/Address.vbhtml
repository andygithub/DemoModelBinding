@ModelType Address
   
    <div class="form-horizontal">
        <h4>Address</h4>
        <hr />
        <div class="form-group">
            @Html.LabelFor(Function(model) model.AddressLine1, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AddressLine1)
                @Html.ValidationMessageFor(Function(model) model.AddressLine1)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.AddressLine2, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AddressLine2)
                @Html.ValidationMessageFor(Function(model) model.AddressLine2)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.City, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.City)
                @Html.ValidationMessageFor(Function(model) model.City)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.State, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.State)
                @Html.ValidationMessageFor(Function(model) model.State)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ZipCode, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ZipCode)
                @Html.ValidationMessageFor(Function(model) model.ZipCode)
            </div>
        </div>
    </div>
