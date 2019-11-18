using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractMainInfoParams {
		
		///<summary>
		/// 主键
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 确认函编号
		///</summary>
		
		private string protNo_;
		
		///<summary>
		/// 签署公司,0:未知，1:唯品会（中国）有限公司及其子公司（珠海子公司，重庆子公司），2：广州唯品会信息科技有限公司 , 3 : 乐蜂（上海）信息技术有限公司，4：Vipshop International Holdings Limited，5：广州好信医药连锁有限公司，6：广州唯品会电子商务有限公司
		///</summary>
		
		private int? companyId_;
		
		///<summary>
		/// 合同编码
		///</summary>
		
		private string contractNo_;
		
		///<summary>
		/// 合同名称
		///</summary>
		
		private string contractName_;
		
		///<summary>
		/// 合同时间
		///</summary>
		
		private long? contractTime_;
		
		///<summary>
		/// 签约模式 （1： 普通模式， 2：电子印章，3：验证码模式）
		///</summary>
		
		private byte? signMode_;
		
		///<summary>
		/// 供应商code
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 专场名称
		///</summary>
		
		private string specialName_;
		
		///<summary>
		/// 活动范围（4:特卖会（含PC + APP + WAP + 唯品会旗舰店（京东）+ 微Q端（京东）），5:其他（花海仓、乐蜂等APP））
		///</summary>
		
		private byte? rangeType_;
		
		///<summary>
		/// 上线时间
		///</summary>
		
		private long? onlineStarttime_;
		
		///<summary>
		/// 下线时间
		///</summary>
		
		private long? onlineEndtime_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string createBy_;
		
		///<summary>
		/// 供应商对接的部门id标识
		///</summary>
		
		private int? departmentId_;
		
		///<summary>
		/// 供应商对接的商务人员id
		///</summary>
		
		private string acceptOperatorId_;
		
		///<summary>
		/// 供应商对接的商务人员名称
		///</summary>
		
		private string acceptOperator_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 品牌SN
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// （作废，换成overseasSalesWarehouseList）档期id
		///</summary>
		
		private int? brandId_;
		
		///<summary>
		/// 业务类型（1：商务，2：海淘）
		///</summary>
		
		private byte? businessType_;
		
		///<summary>
		/// 确认函维度（1：专场维度，2：品牌维度，3：商品维度）
		///</summary>
		
		private byte? contractDimension_;
		
		///<summary>
		/// 签署公司名称
		///</summary>
		
		private string companyName_;
		
		///<summary>
		/// 海淘专场多仓信息
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> salesWarehouseList_;
		
		///<summary>
		/// 确认函模式（0：单一，1：混合）
		///</summary>
		
		private byte? contractMode_;
		
		///<summary>
		/// OXO合同编码
		///</summary>
		
		private string oxoContractNo_;
		
		///<summary>
		/// OXO合同名称
		///</summary>
		
		private string oxoContractName_;
		
		///<summary>
		/// OXO合同时间
		///</summary>
		
		private long? oxoContractTime_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetProtNo(){
			return this.protNo_;
		}
		
		public void SetProtNo(string value){
			this.protNo_ = value;
		}
		public int? GetCompanyId(){
			return this.companyId_;
		}
		
		public void SetCompanyId(int? value){
			this.companyId_ = value;
		}
		public string GetContractNo(){
			return this.contractNo_;
		}
		
		public void SetContractNo(string value){
			this.contractNo_ = value;
		}
		public string GetContractName(){
			return this.contractName_;
		}
		
		public void SetContractName(string value){
			this.contractName_ = value;
		}
		public long? GetContractTime(){
			return this.contractTime_;
		}
		
		public void SetContractTime(long? value){
			this.contractTime_ = value;
		}
		public byte? GetSignMode(){
			return this.signMode_;
		}
		
		public void SetSignMode(byte? value){
			this.signMode_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public string GetSpecialName(){
			return this.specialName_;
		}
		
		public void SetSpecialName(string value){
			this.specialName_ = value;
		}
		public byte? GetRangeType(){
			return this.rangeType_;
		}
		
		public void SetRangeType(byte? value){
			this.rangeType_ = value;
		}
		public long? GetOnlineStarttime(){
			return this.onlineStarttime_;
		}
		
		public void SetOnlineStarttime(long? value){
			this.onlineStarttime_ = value;
		}
		public long? GetOnlineEndtime(){
			return this.onlineEndtime_;
		}
		
		public void SetOnlineEndtime(long? value){
			this.onlineEndtime_ = value;
		}
		public string GetCreateBy(){
			return this.createBy_;
		}
		
		public void SetCreateBy(string value){
			this.createBy_ = value;
		}
		public int? GetDepartmentId(){
			return this.departmentId_;
		}
		
		public void SetDepartmentId(int? value){
			this.departmentId_ = value;
		}
		public string GetAcceptOperatorId(){
			return this.acceptOperatorId_;
		}
		
		public void SetAcceptOperatorId(string value){
			this.acceptOperatorId_ = value;
		}
		public string GetAcceptOperator(){
			return this.acceptOperator_;
		}
		
		public void SetAcceptOperator(string value){
			this.acceptOperator_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public int? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(int? value){
			this.brandId_ = value;
		}
		public byte? GetBusinessType(){
			return this.businessType_;
		}
		
		public void SetBusinessType(byte? value){
			this.businessType_ = value;
		}
		public byte? GetContractDimension(){
			return this.contractDimension_;
		}
		
		public void SetContractDimension(byte? value){
			this.contractDimension_ = value;
		}
		public string GetCompanyName(){
			return this.companyName_;
		}
		
		public void SetCompanyName(string value){
			this.companyName_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> GetSalesWarehouseList(){
			return this.salesWarehouseList_;
		}
		
		public void SetSalesWarehouseList(List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> value){
			this.salesWarehouseList_ = value;
		}
		public byte? GetContractMode(){
			return this.contractMode_;
		}
		
		public void SetContractMode(byte? value){
			this.contractMode_ = value;
		}
		public string GetOxoContractNo(){
			return this.oxoContractNo_;
		}
		
		public void SetOxoContractNo(string value){
			this.oxoContractNo_ = value;
		}
		public string GetOxoContractName(){
			return this.oxoContractName_;
		}
		
		public void SetOxoContractName(string value){
			this.oxoContractName_ = value;
		}
		public long? GetOxoContractTime(){
			return this.oxoContractTime_;
		}
		
		public void SetOxoContractTime(long? value){
			this.oxoContractTime_ = value;
		}
		
	}
	
}