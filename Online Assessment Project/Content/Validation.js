function GeneratePasscode() {
    document.getElementById('Passcode').value = Math.floor((Math.random() * 99999) + 10000);
}
function Validate() {
    if (document.getElementById('TestName').value = "") {
        document.getElementById('1') = "error";
    }
}