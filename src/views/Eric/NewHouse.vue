<template>
  <Layout :title="'成為房東'" :notFirst="false">
    <CreateStep></CreateStep>
  </Layout>
</template>

<script>
import Layout from "../../components/_Eric/NewHouse/Layout.vue";
import CreateStep from "../../components/_Eric/NewHouse/CreateStep.vue";

export default {
  components: {
    Layout,
    CreateStep,
  },
};
</script>