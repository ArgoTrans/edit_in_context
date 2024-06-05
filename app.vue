<script setup>
const url =
  "https://file-examples.com/wp-content/storage/2017/02/file-sample_100kB.doc";
</script>

<template>
  <div>
    <iframe
      :src="`https://view.officeapps.live.com/op/embed.aspx?wdPrint=0&src=${url}`"
    ></iframe>
  </div>
</template>
