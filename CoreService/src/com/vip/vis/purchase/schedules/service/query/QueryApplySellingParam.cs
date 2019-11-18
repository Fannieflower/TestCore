using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class QueryApplySellingParam {
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private List<long?> brandIdList_;
		
		///<summary>
		/// 采购协议编码
		///</summary>
		
		private long? shopCode_;
		
		///<summary>
		/// 采购协议名称
		///</summary>
		
		private string sellingAction_;
		
		///<summary>
		/// 状态
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private int? vendorCode_;
		
		///<summary>
		/// 跟进部门ID
		///</summary>
		
		private List<int?> dataAreaDivideList_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 采购协议开始时间
		///</summary>
		
		private string sellTimeFrom_;
		
		///<summary>
		/// 采购协议结束时间
		///</summary>
		
		private string sellTimeTo_;
		
		///<summary>
		/// 是否海淘
		///</summary>
		
		private byte? isHt_;
		
		///<summary>
		/// 分仓
		///</summary>
		
		private string sellArea_;
		
		///<summary>
		/// 是否运营专场
		///</summary>
		
		private byte? specialOperationsFlag_;
		
		///<summary>
		/// 是否为常态
		///</summary>
		
		private int? isNormalization_;
		
		///<summary>
		/// 查询系统
		///</summary>
		
		private string system_;
		
		///<summary>
		/// 是否查询品牌
		///</summary>
		
		private bool? isNeedQueryBrand_;
		
		///<summary>
		/// 是否查询标签
		///</summary>
		
		private bool? isNeedQueryLabel_;
		
		///<summary>
		/// 当前页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 请求数量
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 是否需要查询三级部类名称
		///</summary>
		
		private bool? isNeedDepartmentIdName_;
		
		///<summary>
		/// 采购协议编码List
		///</summary>
		
		private List<long?> shopCodeList_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private List<byte?> sellingModeArr_;
		
		///<summary>
		/// 是否现在售卖
		///</summary>
		
		private bool? isNowSell_;
		
		public List<long?> GetBrandIdList(){
			return this.brandIdList_;
		}
		
		public void SetBrandIdList(List<long?> value){
			this.brandIdList_ = value;
		}
		public long? GetShopCode(){
			return this.shopCode_;
		}
		
		public void SetShopCode(long? value){
			this.shopCode_ = value;
		}
		public string GetSellingAction(){
			return this.sellingAction_;
		}
		
		public void SetSellingAction(string value){
			this.sellingAction_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public int? GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(int? value){
			this.vendorCode_ = value;
		}
		public List<int?> GetDataAreaDivideList(){
			return this.dataAreaDivideList_;
		}
		
		public void SetDataAreaDivideList(List<int?> value){
			this.dataAreaDivideList_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public string GetSellTimeFrom(){
			return this.sellTimeFrom_;
		}
		
		public void SetSellTimeFrom(string value){
			this.sellTimeFrom_ = value;
		}
		public string GetSellTimeTo(){
			return this.sellTimeTo_;
		}
		
		public void SetSellTimeTo(string value){
			this.sellTimeTo_ = value;
		}
		public byte? GetIsHt(){
			return this.isHt_;
		}
		
		public void SetIsHt(byte? value){
			this.isHt_ = value;
		}
		public string GetSellArea(){
			return this.sellArea_;
		}
		
		public void SetSellArea(string value){
			this.sellArea_ = value;
		}
		public byte? GetSpecialOperationsFlag(){
			return this.specialOperationsFlag_;
		}
		
		public void SetSpecialOperationsFlag(byte? value){
			this.specialOperationsFlag_ = value;
		}
		public int? GetIsNormalization(){
			return this.isNormalization_;
		}
		
		public void SetIsNormalization(int? value){
			this.isNormalization_ = value;
		}
		public string GetSystem(){
			return this.system_;
		}
		
		public void SetSystem(string value){
			this.system_ = value;
		}
		public bool? GetIsNeedQueryBrand(){
			return this.isNeedQueryBrand_;
		}
		
		public void SetIsNeedQueryBrand(bool? value){
			this.isNeedQueryBrand_ = value;
		}
		public bool? GetIsNeedQueryLabel(){
			return this.isNeedQueryLabel_;
		}
		
		public void SetIsNeedQueryLabel(bool? value){
			this.isNeedQueryLabel_ = value;
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
		public bool? GetIsNeedDepartmentIdName(){
			return this.isNeedDepartmentIdName_;
		}
		
		public void SetIsNeedDepartmentIdName(bool? value){
			this.isNeedDepartmentIdName_ = value;
		}
		public List<long?> GetShopCodeList(){
			return this.shopCodeList_;
		}
		
		public void SetShopCodeList(List<long?> value){
			this.shopCodeList_ = value;
		}
		public List<byte?> GetSellingModeArr(){
			return this.sellingModeArr_;
		}
		
		public void SetSellingModeArr(List<byte?> value){
			this.sellingModeArr_ = value;
		}
		public bool? GetIsNowSell(){
			return this.isNowSell_;
		}
		
		public void SetIsNowSell(bool? value){
			this.isNowSell_ = value;
		}
		
	}
	
}