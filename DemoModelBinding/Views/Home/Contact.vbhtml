@ModelType Contact

   <div class="form-horizontal">
        <h4>Contact</h4>
        <hr />
        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContactFirstName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContactFirstName)
                @Html.ValidationMessageFor(Function(model) model.ContactFirstName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContactLastName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContactLastName)
                @Html.ValidationMessageFor(Function(model) model.ContactLastName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContactType, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContactType)
                @Html.ValidationMessageFor(Function(model) model.ContactType)
            </div>
        </div>

    </div>
