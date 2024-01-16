// Include the necessary modules
const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
const sql = require('mssql');

// Create an Express application
const app = express();

// Middleware
app.use(cors());
app.use(bodyParser.json());

const port = process.env.PORT || 3000;

// Database configuration
const config = {
    user: 'sa',
    password: '12345',
    server: 'localhost', 
    database: 'Information',
    options: {
        encrypt: false, // disabling the encryption for the connection
        trustServerCertificate: true, // Trusting the self-signed certificate
    },
};

const poolPromise = new sql.ConnectionPool(config)
  .connect()
  .then(pool => {
    console.log('Connected to MSSQL')
    return pool;
  })
  .catch(err => console.log('Database Connection Failed! Bad Config: ', err));

app.post('/api/newApplication', async (req, res) => {
  try {
    const pool = await poolPromise;
    const query = `INSERT INTO Applications (cnic, firstName, lastName, email, phoneNumber, homeAddress, dob, pageCounts, gender, type, duration) VALUES (@cnic, @firstName, @lastName, @email, @phoneNumber, @homeAddress, @dob, @pageCounts, @gender, @type, @duration)`;

    const result = await pool.request()
      .input('cnic', sql.VarChar, req.body.cnic)
      .input('firstName', sql.VarChar, req.body.firstName)
      .input('lastName', sql.VarChar, req.body.lastName)
      .input('email', sql.VarChar, req.body.email)
      .input('phoneNumber', sql.VarChar, req.body.phoneNumber)
      .input('homeAddress', sql.VarChar, req.body.homeAddress)
      .input('dob', sql.Date, new Date(req.body.dob))
      .input('pageCounts', sql.Int, req.body.pageCounts)
      .input('gender', sql.VarChar, req.body.gender)
      .input('type', sql.VarChar, req.body.type)
      .input('duration', sql.Int, req.body.duration)
      .query(query);

    res.json(result.recordset);
  } catch (err) {
    res.status(500);
    res.send(err.message);
  }
});

// Start the server
app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
