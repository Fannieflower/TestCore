using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsSpecialCoreModel {
		
		///<summary>
		/// 编号
		///</summary>
		
		private string specialNo_;
		
		///<summary>
		/// 1会员等级专享价(子类型：101:会员等级专享价;102:新老客专享价;103:标签人群专享价;104:超级vip专享价) 2大企业专享价
		///</summary>
		
		private int? category_;
		
		///<summary>
		/// 优惠类型 2立减 3折扣
		///</summary>
		
		private int? actType_;
		
		///<summary>
		/// 后台定义为：单一专场31 自营排他5 主题专享价商品6
		///</summary>
		
		private int? actRange_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string actName_;
		
		///<summary>
		/// 提示语
		///</summary>
		
		private string actMsg_;
		
		///<summary>
		/// 专享价商品优惠金额提示语
		///</summary>
		
		private string goodsMsg_;
		
		///<summary>
		/// 图标信息
		///</summary>
		
		private string iconMsg_;
		
		///<summary>
		/// 优惠力度
		///</summary>
		
		private double? favorable_;
		
		///<summary>
		/// 折扣上限 pms_sales_price_config.config_type=4的值
		///</summary>
		
		private string limitPrice_;
		
		///<summary>
		/// 企业ID
		///</summary>
		
		private List<string> enterpriseList_;
		
		///<summary>
		/// 会员等级和折扣列表 目前只支持一条记录
		///</summary>
		
		private List<com.vip.pms.data.service.PmsSpecialFavModel> specialFavList_;
		
		///<summary>
		/// 使用平台 只支持1和2
		///</summary>
		
		private List<string> platformList_;
		
		///<summary>
		/// 开始时间 包含本时间点
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 结束时间 包含本时间点
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 专场列表 取值为pms_sales_price_range.range_id 当actRange为6时，这里是商品ID
		///</summary>
		
		private List<string> specialScopeList_;
		
		///<summary>
		/// 要排除的id,当category为企业专享价,这里是录入分类id
		///</summary>
		
		private List<string> excludeRangeList_;
		
		///<summary>
		/// 图标信息
		///</summary>
		
		private string icon_;
		
		///<summary>
		/// UI主题编码：0-其他,1-最后疯抢
		///</summary>
		
		private int? uiThemeCode_;
		
		///<summary>
		/// 业务场景编码:1-限时快抢;2-付费会员
		///</summary>
		
		private int? businessCode_;
		
		///<summary>
		/// 渠道列表, 比如 0-特卖会, 19-疯抢 等
		///</summary>
		
		private List<int?> channelList_;
		
		///<summary>
		/// 营销对象ID（用于分步提交接口）
		///</summary>
		
		private long? promotionObjectId_;
		
		///<summary>
		/// 主活动号
		///</summary>
		
		private string mainNo_;
		
		///<summary>
		/// 活动所属规划日历Id
		///</summary>
		
		private long? planId_;
		
		///<summary>
		/// 活动预热时间：分钟
		///</summary>
		
		private int? prestartTime_;
		
		///<summary>
		/// 最后疯抢类型 1-短期 2-长期
		///</summary>
		
		private byte? crazyType_;
		
		public string GetSpecialNo(){
			return this.specialNo_;
		}
		
		public void SetSpecialNo(string value){
			this.specialNo_ = value;
		}
		public int? GetCategory(){
			return this.category_;
		}
		
		public void SetCategory(int? value){
			this.category_ = value;
		}
		public int? GetActType(){
			return this.actType_;
		}
		
		public void SetActType(int? value){
			this.actType_ = value;
		}
		public int? GetActRange(){
			return this.actRange_;
		}
		
		public void SetActRange(int? value){
			this.actRange_ = value;
		}
		public string GetActName(){
			return this.actName_;
		}
		
		public void SetActName(string value){
			this.actName_ = value;
		}
		public string GetActMsg(){
			return this.actMsg_;
		}
		
		public void SetActMsg(string value){
			this.actMsg_ = value;
		}
		public string GetGoodsMsg(){
			return this.goodsMsg_;
		}
		
		public void SetGoodsMsg(string value){
			this.goodsMsg_ = value;
		}
		public string GetIconMsg(){
			return this.iconMsg_;
		}
		
		public void SetIconMsg(string value){
			this.iconMsg_ = value;
		}
		public double? GetFavorable(){
			return this.favorable_;
		}
		
		public void SetFavorable(double? value){
			this.favorable_ = value;
		}
		public string GetLimitPrice(){
			return this.limitPrice_;
		}
		
		public void SetLimitPrice(string value){
			this.limitPrice_ = value;
		}
		public List<string> GetEnterpriseList(){
			return this.enterpriseList_;
		}
		
		public void SetEnterpriseList(List<string> value){
			this.enterpriseList_ = value;
		}
		public List<com.vip.pms.data.service.PmsSpecialFavModel> GetSpecialFavList(){
			return this.specialFavList_;
		}
		
		public void SetSpecialFavList(List<com.vip.pms.data.service.PmsSpecialFavModel> value){
			this.specialFavList_ = value;
		}
		public List<string> GetPlatformList(){
			return this.platformList_;
		}
		
		public void SetPlatformList(List<string> value){
			this.platformList_ = value;
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
		public List<string> GetSpecialScopeList(){
			return this.specialScopeList_;
		}
		
		public void SetSpecialScopeList(List<string> value){
			this.specialScopeList_ = value;
		}
		public List<string> GetExcludeRangeList(){
			return this.excludeRangeList_;
		}
		
		public void SetExcludeRangeList(List<string> value){
			this.excludeRangeList_ = value;
		}
		public string GetIcon(){
			return this.icon_;
		}
		
		public void SetIcon(string value){
			this.icon_ = value;
		}
		public int? GetUiThemeCode(){
			return this.uiThemeCode_;
		}
		
		public void SetUiThemeCode(int? value){
			this.uiThemeCode_ = value;
		}
		public int? GetBusinessCode(){
			return this.businessCode_;
		}
		
		public void SetBusinessCode(int? value){
			this.businessCode_ = value;
		}
		public List<int?> GetChannelList(){
			return this.channelList_;
		}
		
		public void SetChannelList(List<int?> value){
			this.channelList_ = value;
		}
		public long? GetPromotionObjectId(){
			return this.promotionObjectId_;
		}
		
		public void SetPromotionObjectId(long? value){
			this.promotionObjectId_ = value;
		}
		public string GetMainNo(){
			return this.mainNo_;
		}
		
		public void SetMainNo(string value){
			this.mainNo_ = value;
		}
		public long? GetPlanId(){
			return this.planId_;
		}
		
		public void SetPlanId(long? value){
			this.planId_ = value;
		}
		public int? GetPrestartTime(){
			return this.prestartTime_;
		}
		
		public void SetPrestartTime(int? value){
			this.prestartTime_ = value;
		}
		public byte? GetCrazyType(){
			return this.crazyType_;
		}
		
		public void SetCrazyType(byte? value){
			this.crazyType_ = value;
		}
		
	}
	
}