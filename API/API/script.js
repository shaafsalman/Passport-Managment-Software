document.querySelector('application-form').addEventListener('submit', async (event) => {
    event.preventDefault();
  
    // Grab all form fields
    const cnic = document.getElementById('cnic').value;
    const firstName = document.getElementById('firstName').value;
    const lastName = document.getElementById('lastName').value;
    const email = document.getElementById('email').value;
    const phoneNumber = document.getElementById('phoneNumber').value;
    const homeAddress = document.getElementById('homeAddress').value;
    const dob = document.getElementById('dob').value;
  
    let pageCounts = [];
    document.querySelectorAll('input[name="pageCounts"]:checked').forEach((checkbox) => {
        pageCounts.push(checkbox.value);
    });
  
    let gender = [];
    document.querySelectorAll('input[name="gender"]:checked').forEach((checkbox) => {
        gender.push(checkbox.value);
    });
  
    let type = [];
    document.querySelectorAll('input[name="type"]:checked').forEach((checkbox) => {
        type.push(checkbox.value);
    });
  
    let duration = [];
    document.querySelectorAll('input[name="duration"]:checked').forEach((checkbox) => {
        duration.push(checkbox.value);
    });

    // Prepare data to send
    const data = {
      cnic,
      firstName,
      lastName,
      email,
      phoneNumber,
      homeAddress,
      dob,
      pageCounts,
      gender,
      type,
      duration
    };

 

    // Here you can add your form validation
    if(cnic.length !== 13) {
      alert("CNIC must be 13 characters");
      return;
    }
  
    // Email validation
    if(!email.includes("@gmail.com")) {
      alert("Email must be a valid Gmail address (include '@gmail.com')");
      return;
    }
  
    // Phone number validation
    if(phoneNumber.length !== 11) {
      alert("Phone number must be 11 digits");
      return;
    }
  
    // Age validation (at least 18 years old)
    const today = new Date();
    const birthDate = new Date(dob);
    const age = today.getFullYear() - birthDate.getFullYear();
    const month = today.getMonth() - birthDate.getMonth();
    if (month < 0 || (month === 0 && today.getDate() < birthDate.getDate())) {
      age--;
    }
  
    if(age < 18) {
      alert("You must be at least 18 years old");
      return;
    }
  
    console.log(data)
    try {
        const response = await fetch('http://localhost:3000/api/newApplication', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify(data)
        });
    
        if (!response.ok) throw new Error('There was an error. Please try again.');
    
        const result = await response.json();
        alert('Application submitted successfully!');
        document.querySelector('form').reset();

        // Redirect to appointment.html
        window.location.href = "C:\Users\Omer Habib\OneDrive\Documents\REST API\appointment.html";
      } catch (error) {
        console.error('Error:', error);
        alert('There was an error. Please try again.');
      }
});

// Path: appointment.html