using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActSiteModel {
		
		///<summary>
		/// id
		///</summary>
		
		private int? siteId_;
		
		///<summary>
		/// 频道描述名称
		///</summary>
		
		private string site_;
		
		///<summary>
		/// 专场列表 普通活动的档期信息表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActScopeModel> actScopeList_;
		
		///<summary>
		/// 搭配优惠的档期信息表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActPsScopeModel> actPsScopeList_;
		
		///<summary>
		/// 档次列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActFavModel> actFavList_;
		
		///<summary>
		/// 一条活动分站表对应多条活动编号表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActNoModel> actNoList_;
		
		///<summary>
		/// 站点类型：1为站点；2为大仓
		///</summary>
		
		private int? siteType_;
		
		///<summary>
		/// 商品列表（如果为分步提交流程，无需设值）
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActGoodsModel> actGoodsList_;
		
		public int? GetSiteId(){
			return this.siteId_;
		}
		
		public void SetSiteId(int? value){
			this.siteId_ = value;
		}
		public string GetSite(){
			return this.site_;
		}
		
		public void SetSite(string value){
			this.site_ = value;
		}
		public List<com.vip.pms.data.service.PmsActScopeModel> GetActScopeList(){
			return this.actScopeList_;
		}
		
		public void SetActScopeList(List<com.vip.pms.data.service.PmsActScopeModel> value){
			this.actScopeList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActPsScopeModel> GetActPsScopeList(){
			return this.actPsScopeList_;
		}
		
		public void SetActPsScopeList(List<com.vip.pms.data.service.PmsActPsScopeModel> value){
			this.actPsScopeList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActFavModel> GetActFavList(){
			return this.actFavList_;
		}
		
		public void SetActFavList(List<com.vip.pms.data.service.PmsActFavModel> value){
			this.actFavList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActNoModel> GetActNoList(){
			return this.actNoList_;
		}
		
		public void SetActNoList(List<com.vip.pms.data.service.PmsActNoModel> value){
			this.actNoList_ = value;
		}
		public int? GetSiteType(){
			return this.siteType_;
		}
		
		public void SetSiteType(int? value){
			this.siteType_ = value;
		}
		public List<com.vip.pms.data.service.PmsActGoodsModel> GetActGoodsList(){
			return this.actGoodsList_;
		}
		
		public void SetActGoodsList(List<com.vip.pms.data.service.PmsActGoodsModel> value){
			this.actGoodsList_ = value;
		}
		
	}
	
}