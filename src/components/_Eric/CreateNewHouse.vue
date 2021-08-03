<template>
  <t></t>
  <div class="page">
    <div class="rent-banner">
      <RentBanner :title="title"></RentBanner>
    </div>
    <div class="rent-content">
      <RentContent>
        <slot></slot>
      </RentContent>
    </div>
  </div>
</template>


<style lang="scss" scoped>
.page {
  display: block;
}

.rent-banner {
  height: 30vh;
  width: 100%;
  position: relative;
}

.rent-content {
  margin-top: -20px;
  padding-top: 40px;
  width: 100%;
  background-color: #fff;
  border-radius: 20px 20px 0 0;
  position: relative;
}

@media screen and (min-width: 750px) {
  .page {
    display: flex;
  }

  .rent-banner {
    height: 100vh;
    margin-bottom: 0;
    width: 50%;
  }

  .rent-content {
    margin-top: 0;
    width: 50%;
    height: 100vh;
  }
}
</style>

<script>
import RentBanner from "./RentBanner.vue";
import RentContent from "./RentContent.vue";
import t from "./HousePublish.vue";

export default {
  props: {
    title: {
      type: String,
      default: "幹0量G8",
    },
  },
  components: {
    RentBanner,
    RentContent,
    t,
  },
};
</script>