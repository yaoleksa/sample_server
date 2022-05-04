const express = require('express');
const path = require('path');
const cors = require('cors');
const https = require('https');
const app = express();

let data = '';

https.get('https://ccdevs-birchgoldgroup.cs66.force.com/webconnector/services/apexrest/', (res) => {
    res.on('data', (chunk) => {
        data += chunk;
    });
    res.on('end', () => {
        console.log(JSON.parse(data));
    });
});

app.use(cors());

 app.get('/', (req, res) => {
     //res.sendFile(path.join(__dirname, './index.html'));
     res.send(data);
 });

 app.post('/', (req, res) => {
    console.log('?');
 });
 
 app.listen(3000, () => {
     console.log('bad');
 })