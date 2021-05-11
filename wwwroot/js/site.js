// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var creatRoomBtn = document.getElementById('create-room-btn')
var creatRoomModel = document.getElementById('create-room-model')

creatRoomBtn.addEventListener('click', function () {
    creatRoomModel.classList.add('active')
})
function closeModel() {
    creatRoomModel.classList.remove('active')

}