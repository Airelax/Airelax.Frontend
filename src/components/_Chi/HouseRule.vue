<template>
{{HouseRuleObj.checkinTime}}
</template>

<script>
export default {
  components: {},
  data: function () {
    return {
      HouseRuleObj: {},
    };
  },
  create() {},
  methods: {},
  mounted: function () {
    axios
      .get(
        "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/develop/fake-room-data.json"
      )
      .then((response) => {
        console.log(response);
        this.HouseRuleObj = response.data.HouseRule;
      });
  },
};
</script>

<style scoped>
</style>