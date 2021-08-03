
<template>
  <div class="contain">
    <div class="create-helper">
      <Helper></Helper>
    </div>
    <div class="content">
      <slot><div class="error">Oops! Something Error</div></slot>
    </div>
    <div class="step-controls">
      <RentStepControl></RentStepControl>
    </div>
  </div>
</template>


<style lang="scss" scoped>
.create-helper {
  display: none;
}

.contain {
  width: 100%;
  height: 100%;
  position: relative;
  display: block;
}

.step-controls {
  padding: 10px 15px;
  width: 100%;
  position: fixed;
  bottom: 0;
  border-top: 1px solid #000;
}

@media screen and (min-width: 750px) {
  .contain {
    display: flex;
    flex-direction: column;
  }

  .content {
    flex-grow: 1;
  }

  .create-helper {
    display: block;
  }

  .step-controls {
    position: static;
  }
}
</style>

<script>
import RentStepControl from "./RentStepControl.vue";
import Helper from "./CreateHouseHelper.vue";
export default {
  components: {
    RentStepControl,
    Helper,
  },
  props: ["cls"],
};
</script>