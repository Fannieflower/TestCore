using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class QueryScheduleByShopCodeParam {
		
		///<summary>
		/// 操作人OA登陆
		///</summary>
		
		private string user_;
		
		///<summary>
		/// 跟进部门ID
		///</summary>
		
		private List<int?> dataAreaDivideList_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private int? vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 采购协议编码List
		///</summary>
		
		private List<long?> shopCodeList_;
		
		///<summary>
		/// 查询系统
		///</summary>
		
		private string callFrom_;
		
		///<summary>
		/// 结算模式
		///</summary>
		
		private byte? cooperationType_;
		
		///<summary>
		/// 售卖标识
		///</summary>
		
		private byte? sellFlag_;
		
		///<summary>
		/// 当前页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 请求数量
		///</summary>
		
		private int? pageSize_;
		
		public string GetUser(){
			return this.user_;
		}
		
		public void SetUser(string value){
			this.user_ = value;
		}
		public List<int?> GetDataAreaDivideList(){
			return this.dataAreaDivideList_;
		}
		
		public void SetDataAreaDivideList(List<int?> value){
			this.dataAreaDivideList_ = value;
		}
		public int? GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(int? value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public List<long?> GetShopCodeList(){
			return this.shopCodeList_;
		}
		
		public void SetShopCodeList(List<long?> value){
			this.shopCodeList_ = value;
		}
		public string GetCallFrom(){
			return this.callFrom_;
		}
		
		public void SetCallFrom(string value){
			this.callFrom_ = value;
		}
		public byte? GetCooperationType(){
			return this.cooperationType_;
		}
		
		public void SetCooperationType(byte? value){
			this.cooperationType_ = value;
		}
		public byte? GetSellFlag(){
			return this.sellFlag_;
		}
		
		public void SetSellFlag(byte? value){
			this.sellFlag_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}