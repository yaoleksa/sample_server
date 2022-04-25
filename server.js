const express = require('express');
const path = require('path');
const app = express();

app.use((req, res, next) => {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST');
    next();
});

 app.get('/', (req, res) => {
     res.sendFile(path.join(__dirname, './index.html'));
 });

 app.post('/', (req, res) => {
    console.log('?');
 });
 
 app.listen(3000, () => {
     console.log('bad');
 })