﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Function for modal window for issues
$(function () {
    var PlaceHolderElement = $("#PlaceHolderHere");
    $("button[data-toggle='ajax-modal']").click(function (event) {
        var url = $(this).data("url");
        $.get(url).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find(".modal").modal("show");
        })
    })

    /*
    PlaceHolderElement.on("click", "[data-save='modal']", function (event) {
        var form = $(this).parents(".modal").find("form");
        var actionUrl = form.attr("action");
        var sendData = form.serialize();
        $.post(actionUrl, sendData).done(function (data) {
            PlaceHolderElement.find(".modal").modal("hide");
        })
    })
    */
})

// Function to hide and display textbox
// Source: https://www.aspsnippets.com/Articles/Show-Hide-TextBox-on-Button-Click-using-JavaScript-and-jQuery.aspx
/*
$(function () {
    $("input[name=textBoxBtn]").click(function () {
        if ($(this).val() == )


    })



})
*/


