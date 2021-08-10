<template>
  <div class="date">
      <div class="txt">
        <h2>選擇入住日期</h2>
        <p v-if="!date.start">新增旅行日期，查看確切價格</p>
        <p v-if="date.start">{{date.start}} ~ {{date.end}}</p>
      </div>
      <div class="picker">
          <v-date-picker id="datepicker" v-model="date" color="pink" is-range :model-config="modelConfig" :columns="$screens({ default: 1, md: 2 })" :rows="$screens({ default: 1})" :min-date="new Date()"/>
          <div class="clear"><a href="#" @click.prevent="clearDate()">清除日期</a></div>
      </div>
  </div>
</template>

<script>
export default {
    data() {
        return {
            date: new Date(),
            modelConfig: {
                type: 'string',
                mask: 'YYYY年MM月DD日'
            },
        }
    },
    watch:{
        date(val){
            this.$emit('update',val)
            this.$emit('outpass',val)
            this.$emit('same',val)
        },
        newdate(val){
            this.date = val
        },
        go(val){
            this.date = val
        },
        same(val){
            this.date = val
        }
    },
    methods:{
        clearDate(){
            this.date = new Date()
        }
    },
    props:["newdate","go","same"]
}
</script>

<style lang="scss" scoped>
.date{
    padding-bottom: 1.5rem;
    margin-top: 1.5rem;
    .txt{
      h2{
        text-align: left;
        font-size: 1.5rem;
        font-weight: 900;
      }
      p{
          text-align: left;
          font-size: 0.9rem;
          color: #717171;
          margin: 1rem 0;
      }
    }
    a{
        text-align: left;
        display: block;
        color: #222222;
        font-size: 1rem;
        margin-left: 1.5rem;
        font-weight: 700;
    }
}
@media screen and (min-width:768px){
    .date{
        border: none;
        .clear{
            display: flex;
            justify-content: flex-end;
        }
    }
}
</style>