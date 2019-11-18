using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActCoreModel {
		
		///<summary>
		/// 1:买赠 2:满减 3:折扣 4:免邮 5:换购 6:买免 7:自由赠 8:虚拟买赠 9:搭配优惠 10:唯品币 11:预付 12: N元任选
		/// 生日赠：actType=1 actGiftType=2
		///</summary>
		
		private int? actType_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string actName_;
		
		///<summary>
		/// 活动平台
		///</summary>
		
		private int? actChannel_;
		
		///<summary>
		/// 0草稿,1,审批,2退回,3审批通过,-1作废
		///仅有pms_act_core.status=3的后台记录会同步到前台，对应activity.status=1
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 自营排他5 专场组合3 商品组合4 单一商品41
		///需要保证该定义与pms_act_scope.scope_type一致。
		///3->object_type=1
		///4->object_type=3
		///41->object_type=??
		///5->映射成2条记录，object_type=5,object_type=1
		///其中object_type=5的记录需要在promotion_object_range表中插入一条range_id='0'的记录表明供应商为唯品会。
		///</summary>
		
		private int? actRange_;
		
		///<summary>
		/// 活动开始时间 包含本时间点
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 活动结束时间 包含本时间点
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 提示语
		///</summary>
		
		private string actMsg_;
		
		///<summary>
		/// 活动优先级
		///</summary>
		
		private int? priorityLevel_;
		
		///<summary>
		/// 活动的拼团标识
		///</summary>
		
		private com.vip.pms.data.enums.GroupBuyingFlag? groupBuyingFlag_;
		
		///<summary>
		/// 预付活动的优惠类型，当活动类型为预付时必传。
		///</summary>
		
		private com.vip.pms.data.enums.PrepayFavType? prepayFavType_;
		
		///<summary>
		/// 销售模式，当活动类型为退货运费险时必传。
		///</summary>
		
		private List<string> saleModes_;
		
		///<summary>
		/// 活动是否支持预付标志
		///</summary>
		
		private com.vip.pms.data.enums.SupportPrepayFlag? supportPrepayFlag_;
		
		///<summary>
		/// 主活动编号
		///</summary>
		
		private long? actMainNo_;
		
		///<summary>
		/// 品类列表
		///</summary>
		
		private List<com.vip.pms.data.service.CouponRangeModel> categoryList_;
		
		///<summary>
		/// 分类导航ID
		///</summary>
		
		private string categoryChannelId_;
		
		///<summary>
		/// 选购线Icon提示语
		///</summary>
		
		private string shopIconMsg_;
		
		///<summary>
		/// 购物车Icon提示语
		///</summary>
		
		private string cartIconMsg_;
		
		///<summary>
		/// 活动预热时间：分钟
		///</summary>
		
		private int? prestartTime_;
		
		///<summary>
		/// 业务属性编码：1-最后疯抢
		///</summary>
		
		private int? label_;
		
		///<summary>
		/// 活动范围对应的销售模式，0 自营 1 直发 2 海淘
		///</summary>
		
		private int? activityRangeSalesMode_;
		
		///<summary>
		/// 渠道列表, 比如 0-特卖会, 19-疯抢 等
		///</summary>
		
		private List<int?> channelList_;
		
		///<summary>
		/// 预付尾款开始时间
		///</summary>
		
		private long? prepayTailMoneyBeginTime_;
		
		///<summary>
		/// 预付尾款结束时间
		///</summary>
		
		private long? prepayTailMoneyEndTime_;
		
		///<summary>
		/// 使用促销图：0-使用原图；1-使用买赠促销图
		///</summary>
		
		private byte? usePromoPic_;
		
		///<summary>
		/// 规划日历的规划id
		///</summary>
		
		private long? planId_;
		
		///<summary>
		/// 是否为限量活动 1:是  0:否
		///</summary>
		
		private byte? isQuota_;
		
		public int? GetActType(){
			return this.actType_;
		}
		
		public void SetActType(int? value){
			this.actType_ = value;
		}
		public string GetActName(){
			return this.actName_;
		}
		
		public void SetActName(string value){
			this.actName_ = value;
		}
		public int? GetActChannel(){
			return this.actChannel_;
		}
		
		public void SetActChannel(int? value){
			this.actChannel_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public int? GetActRange(){
			return this.actRange_;
		}
		
		public void SetActRange(int? value){
			this.actRange_ = value;
		}
		public long? GetBeginTime(){
			return this.beginTime_;
		}
		
		public void SetBeginTime(long? value){
			this.beginTime_ = value;
		}
		public long? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(long? value){
			this.endTime_ = value;
		}
		public string GetActMsg(){
			return this.actMsg_;
		}
		
		public void SetActMsg(string value){
			this.actMsg_ = value;
		}
		public int? GetPriorityLevel(){
			return this.priorityLevel_;
		}
		
		public void SetPriorityLevel(int? value){
			this.priorityLevel_ = value;
		}
		public com.vip.pms.data.enums.GroupBuyingFlag? GetGroupBuyingFlag(){
			return this.groupBuyingFlag_;
		}
		
		public void SetGroupBuyingFlag(com.vip.pms.data.enums.GroupBuyingFlag? value){
			this.groupBuyingFlag_ = value;
		}
		public com.vip.pms.data.enums.PrepayFavType? GetPrepayFavType(){
			return this.prepayFavType_;
		}
		
		public void SetPrepayFavType(com.vip.pms.data.enums.PrepayFavType? value){
			this.prepayFavType_ = value;
		}
		public List<string> GetSaleModes(){
			return this.saleModes_;
		}
		
		public void SetSaleModes(List<string> value){
			this.saleModes_ = value;
		}
		public com.vip.pms.data.enums.SupportPrepayFlag? GetSupportPrepayFlag(){
			return this.supportPrepayFlag_;
		}
		
		public void SetSupportPrepayFlag(com.vip.pms.data.enums.SupportPrepayFlag? value){
			this.supportPrepayFlag_ = value;
		}
		public long? GetActMainNo(){
			return this.actMainNo_;
		}
		
		public void SetActMainNo(long? value){
			this.actMainNo_ = value;
		}
		public List<com.vip.pms.data.service.CouponRangeModel> GetCategoryList(){
			return this.categoryList_;
		}
		
		public void SetCategoryList(List<com.vip.pms.data.service.CouponRangeModel> value){
			this.categoryList_ = value;
		}
		public string GetCategoryChannelId(){
			return this.categoryChannelId_;
		}
		
		public void SetCategoryChannelId(string value){
			this.categoryChannelId_ = value;
		}
		public string GetShopIconMsg(){
			return this.shopIconMsg_;
		}
		
		public void SetShopIconMsg(string value){
			this.shopIconMsg_ = value;
		}
		public string GetCartIconMsg(){
			return this.cartIconMsg_;
		}
		
		public void SetCartIconMsg(string value){
			this.cartIconMsg_ = value;
		}
		public int? GetPrestartTime(){
			return this.prestartTime_;
		}
		
		public void SetPrestartTime(int? value){
			this.prestartTime_ = value;
		}
		public int? GetLabel(){
			return this.label_;
		}
		
		public void SetLabel(int? value){
			this.label_ = value;
		}
		public int? GetActivityRangeSalesMode(){
			return this.activityRangeSalesMode_;
		}
		
		public void SetActivityRangeSalesMode(int? value){
			this.activityRangeSalesMode_ = value;
		}
		public List<int?> GetChannelList(){
			return this.channelList_;
		}
		
		public void SetChannelList(List<int?> value){
			this.channelList_ = value;
		}
		public long? GetPrepayTailMoneyBeginTime(){
			return this.prepayTailMoneyBeginTime_;
		}
		
		public void SetPrepayTailMoneyBeginTime(long? value){
			this.prepayTailMoneyBeginTime_ = value;
		}
		public long? GetPrepayTailMoneyEndTime(){
			return this.prepayTailMoneyEndTime_;
		}
		
		public void SetPrepayTailMoneyEndTime(long? value){
			this.prepayTailMoneyEndTime_ = value;
		}
		public byte? GetUsePromoPic(){
			return this.usePromoPic_;
		}
		
		public void SetUsePromoPic(byte? value){
			this.usePromoPic_ = value;
		}
		public long? GetPlanId(){
			return this.planId_;
		}
		
		public void SetPlanId(long? value){
			this.planId_ = value;
		}
		public byte? GetIsQuota(){
			return this.isQuota_;
		}
		
		public void SetIsQuota(byte? value){
			this.isQuota_ = value;
		}
		
	}
	
}