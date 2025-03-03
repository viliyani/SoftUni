function solve(employeesString, filter) {
    let employees = JSON.parse(employeesString);

    if (filter != 'all') {
        let [filterProperty, filterValue] = filter.split('-');
        filteredEmployees = employees.filter(employee => {
            return employee[filterProperty] == filterValue;
        });
    }

    filteredEmployees.forEach((employee, index) => {
        console.log(`${index}. ${employee.first_name} ${employee.last_name} - ${employee.email}`);
    });
}

solve(`[{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  },  
{
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }]`, 
  'gender-Female');