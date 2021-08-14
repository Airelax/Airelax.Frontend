<template>
  <v-date-picker
    id="datepicker"
    v-model="$store.state.date"
    color="pink"
    is-range
    :model-config="modelConfig"
    :columns="$screens({ default: 1, md: 2 })"
    :rows="$screens({ default: 1 })"
    :min-date="new Date()"
  />
</template>

<script>
export default {
  data() {
    return {
      modelConfig: {
        type: "string",
        mask: "MM月DD日",
      },
    };
  },
};
</script>