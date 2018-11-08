let time = new Date();

if (time.getHours() < 9){
    console.log('Good morning. Today: ' + time);
}
else if (time.getHours() >= 9 && time.getHours() <= 17){
    console.log('Good day. Today: ' + time);
}
else{
    console.log('Good evening. Today: ' + time);
}
alert("Today: " + time);
