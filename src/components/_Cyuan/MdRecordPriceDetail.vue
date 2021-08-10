<template>
  <div
    v-if="price && fullWidth >= 768"
    class="position-absolute"
    id="mdRecordPriceDetail"
  >
    <div class="header d-flex align-items-center">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-toggle="collapse"
        href="#mdRecordPriceDetail"
        aria-label="Close"
      ></button>
      <div class="title mx-auto">價格明細</div>
    </div>
    <div class="body">
      <div class="row">
        <div class="col-7">
          ${{ convertToLocaleString(Number(price.sweetPrice)) }}x{{
            nightCount
          }}晚
        </div>
        <div class="col">
          ${{ convertToLocaleString(Number(price.sweetPrice) * nightCount) }}
        </div>
      </div>
      <div class="row" v-if="price.Fee.CleanFee">
        <div class="col-7">清潔費</div>
        <div class="col">
          ${{ convertToLocaleString(Number(price.Fee.CleanFee)) }}
        </div>
      </div>
      <div class="row" v-if="price.Fee.ServiceFee">
        <div class="col-7">服務費</div>
        <div class="col">
          ${{ convertToLocaleString(Number(price.Fee.ServiceFee)) }}
        </div>
      </div>

      <div class="row" v-if="price.Fee.taxFee">
        <p class="col-7">稅額</p>
        <p class="col">
          ${{ convertToLocaleString(Number(price.Fee.taxFee)) }}
        </p>
      </div>
    </div>
  </div>
</template>
<style lang="scss" scoped>
* {
  // border: 1px solid blue;
}
@media screen and(max-width:768px) {
  .position-absolute {
    display: none;
  }
}

.position-absolute {
  border: 0.5px solid #ededed;
  box-shadow: 0px 1px 15px 0.5px #aaa;
  background-color: #fff;
  border-radius: 18px;
  z-index: 18;
  width: 250px;
  bottom: 310px;
  .header {
    padding: 10px 20px;
    color: #000;
    .btn-close {
      font-size: 12px;
      opacity: 1;
    }
  }
  .body {
    padding: 10px 10px;
    border-top: 0.5px solid #ededed;
    .row {
      margin: 5px 0;
      .col:nth-of-type(1) {
        text-align: start;
      }
      .col:nth-of-type(2) {
        text-align: end;
      }
    }
  }
}
</style>
<script>
export default {
  props: {
    price: {
      type: Object,
    },
    nightCount: {
      type: Number,
    },
  },
  methods: {
    convertToLocaleString(price) {
      return price.toLocaleString();
    },
    plusServiceFee(price, nightCount) {
      return Math.round(
        (Number(price.sweetPrice) * nightCount + Number(price.Fee.ServiceFee)) /
          nightCount
      ).toLocaleString();
    },
    getTotal(price, nightCount) {
      let feeTotal;
      let sweetprice = price.sweetPrice;
      let cleanFee = price.Fee.CleanFee;
      let taxFee = price.Fee.taxFee;
      let serviceFee = price.Fee.ServiceFee;
      if (cleanFee && taxFee && serviceFee) {
        feeTotal = Number(cleanFee) + Number(serviceFee) + Number(taxFee);
      } else if (!cleanFee && !taxFee && !serviceFee) {
        feeTotal = Number(serviceFee);
      } else if (cleanFee && !taxFee && serviceFee) {
        feeTotal = Number(serviceFee) + Number(cleanFee);
      } else if (!cleanFee && taxFee && serviceFee) {
        feeTotal = Number(taxFee) + Number(serviceFee);
      }
      return (Number(sweetprice) * nightCount + feeTotal).toLocaleString();
    },
  },
  data() {
    return {
      fullWidth: 0,
      fullHeight: 0,
    };
  },
  watch: {
    fullWidth(val) {
      this.fullWidth = val;
    },
  },
  mounted() {
    const vm = this;
    this.fullWidth = document.body.clientWidth;
    window.addEventListener("resize", function () {
      vm.fullWidth = document.body.clientWidth;
    });
  },
};
</script>