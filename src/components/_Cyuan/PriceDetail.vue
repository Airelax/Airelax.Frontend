<template>
  <div
    class="offcanvas offcanvas-bottom"
    tabindex="-1"
    id="detail"
    aria-labelledby="detailTitle"
  >
    <div class="offcanvas-header">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-dismiss="offcanvas"
        aria-label="Close"
      ></button>
      <p class="offcanvas-title" id="detailTitle">價格明細</p>
    </div>
    <div class="offcanvas-body small">
      <div class="calTotal">
        <p>${{ prices.sweetPrice }} x {{ nightCount }}晚</p>
        <p>${{ prices.sweetPrice * nightCount }}</p>
      </div>
      <div class="row list">
        <div class="col">
          <div
            class="row"
            v-for="feeName in Object.keys(prices.Fee)"
            :key="feeName.index"
          >
            <p v-if="feeName == 'CleanFee'">清潔費</p>
            <p v-if="feeName == 'ServiceFee'">服務費</p>
            <p v-if="feeName == 'taxFee'">稅額</p>
          </div>
        </div>
        <div class="col">
          <div
            class="row fee text-end"
            v-for="fee in prices.Fee"
            :key="fee.index"
          >
            <p>${{ fee }}</p>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<style lang="scss" scoped>
.offcanvas {
  border-top-left-radius: 12px;
  border-top-right-radius: 12px;
  height: auto;
  .offcanvas-header {
    border-bottom: 0.5px solid #ededed;
    padding: 20px;
    .btn-close {
      color: #000;
      opacity: 1;
      font-size: 12px;
    }
    .btn-close:hover {
      background-color: #efefef80;
      border-radius: 50%;
    }
    .offcanvas-title {
      margin: auto;
      font-size: 16px;
      font-weight: 500;
    }
  }
  .offcanvas-body {
    font-size: 15px;
    padding: 20px;
    .calTotal {
      display: flex;
      flex-direction: row;
      justify-content: space-between;
      letter-spacing: 1px;
    }
    .list {
      .col {
        .fee {
          text-align: end;
        }
      }
    }
  }
}
</style>

<script>
export default {
  props: ["prices", "nightCount", "sweetPrices"],
  methods: {
    console(a) {
      console.log(a);
    },
  },
};
</script>