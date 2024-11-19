window.saveAsFile = function (filename, byteBase64) {
    var link = document.createElement('a');
    link.href = 'data:application/octet-stream;base64,' + byteBase64;
    link.download = filename;
    link.click();
};