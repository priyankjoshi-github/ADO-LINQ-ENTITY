@model MvcCrudOperation.Context.FootBallLeague
@{
    ViewBag.Title = "Football";
}
<style>
  .error{
      color:red;
  }
</style>

@using (Html.BeginForm("AddFootball", "Football", FormMethod.Post))

{
    <div class="container">
        <div class="form-group">
            <label>Match Id</label>
            @Html.ValidationMessageFor(x => x.MatchId,"" ,new { @class="error" })
            @Html.TextBoxFor(x => x.MatchId, new { @class = "form-control" })

        </div>
        <div class="form-group">
            <label>Team1</label>
            @Html.ValidationMessageFor(x => x.TeamName1, "", new { @class = "error" })
            @Html.TextBoxFor(x => x.TeamName1, new { @class = "form-control" })

        </div>
        <div class="form-group">
            <label>Team2</label>
            @Html.ValidationMessageFor(x => x.TeamName2, "", new { @class = "error" })
            @Html.TextBoxFor(x => x.TeamName2, new { @class = "form-control" })

        </div>

        <div class="form-group">
            <label>Match Status</label>
            @Html.ValidationMessageFor(x => x.MatchStatus, "", new { @class = "error" })
            @Html.TextBoxFor(x => x.MatchStatus, new { @class = "form-control" })

        </div>
        <div class="form-group">
            <label>Winning</label>
            @Html.ValidationMessageFor(x => x.WinningTeam, "", new { @class = "error" })
            @Html.TextBoxFor(x => x.WinningTeam, new { @class = "form-control" })

        </div>
        <div class="form-group">
            <label>Points</label>
            @Html.ValidationMessageFor(x => x.Points, "", new { @class = "error" })
            @Html.TextBoxFor(x => x.Points, new { @class = "form-control" })

        </div>
        <div class="form-group">
            <button class="btn btn-primary" type="submit">Submit</button>
            <button class="btn btn-primary" type="reset">Cancel</button>
        </div>



    </div>

}