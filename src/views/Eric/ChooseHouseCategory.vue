<template>
  <Layout :title="'你想出租哪種類型的房源？'">
    <SelectHouseCategory></SelectHouseCategory>
  </Layout>
</template>

<script>
import Layout from "../../components/_Eric/NewHouse/Layout.vue";
import SelectHouseCategory from "../../components/_Eric/NewHouse/SelectHouseCategoryContent.vue";

export default {
  components: {
    Layout,
    SelectHouseCategory,
  },
};
</script>