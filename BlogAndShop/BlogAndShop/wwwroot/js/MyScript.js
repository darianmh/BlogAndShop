/*  NewsLetter  */
function SendNewsEmail() {
  var mail = $("#newsLetterEmail").val();
  AJAXPost('/Home/AddEmailLetter?email=' + mail, "", SendNewsEmailCb);
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


//profile addresses
function setAddressEditRecord(City, Street, SecondaryStreet, Alley, Number, Details, Id) {
  $('input[name="City"]').val(City);
  $('input[name="Street"]').val(Street);
  $('input[name="SecondaryStreet"]').val(SecondaryStreet);
  $('input[name="Alley"]').val(Alley);
  $('input[name="Number"]').val(Number);
  $('input[name="Details"]').val(Details);
  $('input[name="Id"]').val(Id);
  $("#exampleModalMd").modal('show');
}

//post comment
function ReplyPostComment(commentId, name) {
  $("#CommentParentId").val(commentId);
  var alertText =
    '<div class="alert alert-info" role="alert"><button onclick="CancelReplyPostComment()" type="button" class="close" data-dismiss="alert" aria-label="Close"><span class="fi fi-close" aria-hidden="true"></span></button>پاسخ به: ' + name + '</div>';
  $("#replyAlert").html(alertText);
}
function CancelReplyPostComment() {
  $("#replyAlert").html('');
  $("#CommentParentId").val('');
}