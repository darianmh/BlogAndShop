// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var preventRegister = false;

function registerCourse() {
  if (preventRegister) return;
  var courseId = $("#courseId").val();
  var courseTitle = $("#courseTitle").text();
  $("#RegisterCourseId").val(courseId);
  $("#registerCourseTitle").text("ثبت نام " + courseTitle);
  $("#registercourse").slideDown(1000, function () {
    window.location = '#registercourse';
  });
}
function showDetails(id, title, price, courseId) {
  var description = $("#description_" + courseId).val();
  $("#courseTitle").text(title);
  $("#courseDescription").html(description);
  $("#coursePrice").text(price);
  $("#courseId").val(courseId);
  $("#coursesdetails").slideDown(1000, function () {
    window.location = '#coursesdetails';
  });
}

function backToCourses() {
  window.location = '#courses';
  $("#registercourse").hide();
  $("#coursesdetails").slideUp(1000, function () {
  });
}


$("#RegisterForm").submit(function (e) {
  e.preventDefault();
  var model = {
    FirstName: $("#FirstName").val(),
    LastName: $("#LastName").val(),
    PhoneNumber: $("#PhoneNumber").val(),
    RegisterDescription: $("#RegisterDescription").val(),
    RegisterCourseId: $("#RegisterCourseId").val()
  }
  $.ajax({
    url: "/home/Register",
    dataType: "json",
    data: model,
  }).done(function () {
    $("#registercourse").hide();
    $("#coursesdetails").hide();
    $("#successRegister").show();
    preventRegister = true;
  });
});
