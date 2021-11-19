/*  NewsLetter  */
function SendNewsEmail() {
  var mail = $("#newsLetterEmail").val();
  AJAXPost('/Home/AddEmailLetter?email=' ? +mail, "", SendNewsEmailCb);
}
function SendNewsEmailCb(data) {
  MyAlert("ایمیل افزوده شد");
}

/* Common  */
function MyAlert(text) {
  alert(text);
}


/*  Loading  */
function startLoading() {
  $('.loader').show();
}
function stopLoading() {
  $('.loader').show();
}

/*  Common Ajax  */
function AJAXGet(url, callBack, errorCallBack) {
  startLoading();
  $.ajax({
    url: url,
    success: function (data) {
      console.log(data);
      if (data.ok) {
        callBack(data.data);
      } else {
        errorCallBack(data.data);
      }
      stopLoading();
    },
    error: function (data) {
      stopLoading();
    }
  });
}
function AJAXPost(url, data, callBack, errorCallBack) {
  startLoading();
  $.ajax({
    url: url,
    data: data,
    type: "POST",
    success: function (data) {
      console.log(data);
      if (data.ok) {
        callBack(data.data);
      } else {
        errorCallBack(data.data);
      }
      stopLoading();
    },
    error: function (data) {
      stopLoading();
    }
  });
}