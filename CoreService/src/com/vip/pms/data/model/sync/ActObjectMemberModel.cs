using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class ActObjectMemberModel {
		
		///<summary>
		/// 排除标记。false:包含  true:排除。自营排他/品类券可能同时有“排除”和“包含”，普通活动目前只有“包含”。
		///</summary>
		
		private bool? excludeFlag_;
		
		///<summary>
		/// 后台定义的范围类型
		/// <p>活动   ==> 3:专场组合  5:自营排他  4:商品组合(常态或者特卖)  70:品类列表  71:分类导航ID(品类)  8:尺码
		/// <p>专享价 ==> 31:专场  6:商品
		///</summary>
		
		private int? actRange_;
		
		///<summary>
		/// 营销对象列表
		///</summary>
		
		private List<com.vip.pms.data.model.sync.ActObjectRangeModel> objectRangeModelList_;
		
		///<summary>
		/// 商品详细信息列表，比如单品直降的价格信息等
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActGoodsModel> actGoodsList_;
		
		public bool? GetExcludeFlag(){
			return this.excludeFlag_;
		}
		
		public void SetExcludeFlag(bool? value){
			this.excludeFlag_ = value;
		}
		public int? GetActRange(){
			return this.actRange_;
		}
		
		public void SetActRange(int? value){
			this.actRange_ = value;
		}
		public List<com.vip.pms.data.model.sync.ActObjectRangeModel> GetObjectRangeModelList(){
			return this.objectRangeModelList_;
		}
		
		public void SetObjectRangeModelList(List<com.vip.pms.data.model.sync.ActObjectRangeModel> value){
			this.objectRangeModelList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActGoodsModel> GetActGoodsList(){
			return this.actGoodsList_;
		}
		
		public void SetActGoodsList(List<com.vip.pms.data.service.PmsActGoodsModel> value){
			this.actGoodsList_ = value;
		}
		
	}
	
}