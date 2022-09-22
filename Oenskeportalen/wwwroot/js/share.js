function share() {
    var text = "delelink1234";
    // Copy the text inside the text field
    navigator.clipboard.writeText(text);

    // Alert the copied text
    alert("Dit delelink er nu kopieret: " + text);
}