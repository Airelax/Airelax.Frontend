<template>
  <div
    class="offcanvas offcanvas-bottom"
    tabindex="-1"
    id="wish"
    aria-labelledby="wishTitle"
  >
    <div class="offcanvas-header">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-dismiss="offcanvas"
        aria-label="Close"
      ></button>
      <p class="offcanvas-title" id="wishTitle">心願單</p>
    </div>
    <div class="offcanvas-body small">
      <div class="row">
        <div class="col-3 btn">
          <img src="https://picsum.photos/70/70/?random=1" />
        </div>
        <div class="col-9 btn">心願單名字</div>
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
    padding: 12px;
    .btn-close {
      color: #000;
      opacity: 1;
      font-size: 10px;
    }
    .btn-close:hover {
      background-color: #efefef80;
      border-radius: 50%;
    }
    .offcanvas-title {
      margin: auto;
      font-size: 15px;
      font-weight: 400;
    }
  }
  .offcanvas-body {
    font-size: 15px;
    padding: 20px 27px;
    .row {
      .col-3 {
        img {
          border-radius: 10px;
        }
      }
      .col-9 {
        font-size: 18px;
        text-align: start;
        margin-top: auto;
        margin-bottom: auto;
      }
    }
  }
}
</style>


<script>
export default {};
</script>