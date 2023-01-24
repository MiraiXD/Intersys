function fixAge(ages) {
    let result = ages.filter(age => age >= 18 && age <= 60).join(",");
    if (result === "") {
      return "NA";
    }
    return result;
  }