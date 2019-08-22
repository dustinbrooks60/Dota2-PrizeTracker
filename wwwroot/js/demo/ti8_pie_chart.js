// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

// Pie Chart Example
var ctx = document.getElementById("TI8PieChart");
var myPieGraph = new Chart(ctx, {
  type: 'pie',
  data: {
    labels: ["1st Place", "2nd Place", "3rd Place", "4th Place", "5th-6th Place", "7th-8th Place", "9th-12th Place", "13th-16th Place", "17th-18th Place"],
    datasets: [{
      data: [11234158, 4085148, 2680879, 1787252, 1148948, 638304, 382983, 127661, 63830],
      backgroundColor: ['#4e73df', '#1cc88a', '#FFFF00'],
      hoverBackgroundColor: ['#2e59d9', '#17a673'],
      hoverBorderColor: "rgba(234, 236, 244, 1)",
    }],
  },
  options: {
    maintainAspectRatio: false,
    tooltips: {
      backgroundColor: "rgb(255,255,255)",
      bodyFontColor: "#858796",
      borderColor: '#dddfeb',
      borderWidth: 1,
      xPadding: 15,
      yPadding: 15,
      displayColors: false,
      caretPadding: 10,
    },
    legend: {
      display: false
    },

  },
});
