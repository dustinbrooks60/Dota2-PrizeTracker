// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

// Pie Chart Example
var ctx = document.getElementById("TI6PieChart");
var myPieGraph = new Chart(ctx, {
  type: 'pie',
  data: {
    labels: ["1st Place", "2nd Place", "3rd Place", "4th Place", "5th-6th Place", "7th-8th Place", "9th-12th Place", "13th-16th Place", "17th-18th Place"],
    datasets: [{
      data: [9139002, 3427126, 2180898, 1453932, 934671, 519262, 311557, 103852, 61720],
      backgroundColor: ['#FFD700', '#C0C0C0', '#B08D57', "#b87333", "#B22222", "#8E44AD", "#4e73df", '#1cc88a', '#FFA500'],
      hoverBackgroundColor: [],
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
      display: true,
      position: 'bottom'
    },

  },
});
