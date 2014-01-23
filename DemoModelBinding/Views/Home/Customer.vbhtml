@ModelType Customer
  
    <div class="form-horizontal">
        <h4>Customer</h4>
        <hr />
        <div class="form-group">
            @Html.LabelFor(Function(model) model.FirstName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FirstName)
                @Html.ValidationMessageFor(Function(model) model.FirstName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LastName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.LastName)
                @Html.ValidationMessageFor(Function(model) model.LastName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Account, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Account)
                @Html.ValidationMessageFor(Function(model) model.Account)
            </div>
        </div>

    </div>
