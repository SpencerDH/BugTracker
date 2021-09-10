(function($) {
    "use strict"; // Start of use strict

  // Toggle the side navigation
  $("#sidebarToggle, #sidebarToggleTop").on('click', function(e) {
    $("body").toggleClass("sidebar-toggled");
    $(".sidebar").toggleClass("toggled");
    if ($(".sidebar").hasClass("toggled")) {
      $('.sidebar .collapse').collapse('hide');
    };
  });

  // Close any open menu accordions when window is resized below 768px
  $(window).resize(function() {
    if ($(window).width() < 768) {
      $('.sidebar .collapse').collapse('hide');
    };
    
    // Toggle the side navigation when window is resized below 480px
    if ($(window).width() < 480 && !$(".sidebar").hasClass("toggled")) {
      $("body").addClass("sidebar-toggled");
      $(".sidebar").addClass("toggled");
      $('.sidebar .collapse').collapse('hide');
    };
  });

  // Prevent the content wrapper from scrolling when the fixed side navigation hovered over
  $('body.fixed-nav .sidebar').on('mousewheel DOMMouseScroll wheel', function(e) {
    if ($(window).width() > 768) {
      var e0 = e.originalEvent,
        delta = e0.wheelDelta || -e0.detail;
      this.scrollTop += (delta < 0 ? 1 : -1) * 30;
      e.preventDefault();
    }
  });

  // Scroll to top button appear
  $(document).on('scroll', function() {
    var scrollDistance = $(this).scrollTop();
    if (scrollDistance > 100) {
      $('.scroll-to-top').fadeIn();
    } else {
      $('.scroll-to-top').fadeOut();
    }
  });

  // Smooth scrolling using jQuery easing
  $(document).on('click', 'a.scroll-to-top', function(e) {
    var $anchor = $(this);
    $('html, body').stop().animate({
      scrollTop: ($($anchor.attr('href')).offset().top)
    }, 1000, 'easeInOutExpo');
    e.preventDefault();
  });

    

})(jQuery); // End of use strict

// jQuery to open modular pages
$(function () {
    var PageWithModal = $("#PageWithModal");
    $("button[data-toggle='ajax-modal']").click(function (event) {
        var url = $(this).data("url");
        $.get(url).done(function (data) {
            PageWithModal.html(data);
            PageWithModal.find(".modal").modal("show");
        });
    });
});

// jQuery to pass user-to-issue assignment ViewModel to issues controller
$(document).ready(function () {
    $("div#PageWithModal").on("click", "button#user-to-issue-assignment-button", function () {
        // Extract variables
        var issueID = $("div#user-to-issue-assignment-issue-id").text();
        var username = $("select#issue-assignment-username-list").val();

        // Put variables into object
        var userIssueAssignment = new Object();
        userIssueAssignment.IssueID = issueID;
        userIssueAssignment.AppUserName = username;

        // Submitting user assignment to controller through AJAX
        $.ajax({
            type: "POST",
            url: "/Issues/AssignUserToIssue",
            dataType: "json",
            data: userIssueAssignment,
            success: function () {
                console.log("Success");
            },
            error: function () {
                console.log("Error has occurred");
            }
        });

    });
});