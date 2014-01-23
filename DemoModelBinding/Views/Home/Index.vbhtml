@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href="http://asp.net" class="btn btn-primary btn-large">Learn more &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-10">
        @Using (Html.BeginForm("ExampleFormHCSISCombined", "Home"))
                @Html.AntiForgeryToken()
    @<text>
        <div class="form-group">
            <label class="control-label col-md-2" for="onlyform">Only Form</label>
            <div class="col-md-10">
                <input class="text-box single-line"  id="onlyform" name="onlyform" type="text" value="" />
            </div>
        </div>

            @Html.Partial("Customer")
            @Html.Partial("Address")
            @Html.Partial("Contact")
                <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" class="btn btn-default" value="Submit" />
        </div>
    </div>
</text>
        End Using

</div>
</div>

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section