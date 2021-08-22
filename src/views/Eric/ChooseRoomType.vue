<template>
  <Layout :title="'你想出租哪種類型的房源？'">
    <SelectRoomType></SelectRoomType>
  </Layout>
</template>

<script>
import Layout from "../../components/_Eric/NewHouse/Layout.vue";
import SelectRoomType from "../../components/_Eric/NewHouse/SelectRoomTypeContent.vue";

export default {
  components: {
    Layout,
    SelectRoomType,
  },
};
</script>