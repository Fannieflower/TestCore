using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class PurchaseOrderModelHelper : TBeanSerializer<PurchaseOrderModel>
	{
		
		public static PurchaseOrderModelHelper OBJ = new PurchaseOrderModelHelper();
		
		public static PurchaseOrderModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrderModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("batchNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBatchNo(value);
					}
					
					
					
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("purchaseNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseNo(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("approvalStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetApprovalStatus(value);
					}
					
					
					
					
					
					if ("deliveryStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetDeliveryStatus(value);
					}
					
					
					
					
					
					if ("buyerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerId(value);
					}
					
					
					
					
					
					if ("stockProps".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetStockProps(value);
					}
					
					
					
					
					
					if ("deliveryWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryWarehouse(value);
					}
					
					
					
					
					
					if ("disabilityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDisabilityLevel(value);
					}
					
					
					
					
					
					if ("purchaseQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPurchaseQuantity(value);
					}
					
					
					
					
					
					if ("totalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTotalAmount(value);
					}
					
					
					
					
					
					if ("holdQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetHoldQuantity(value);
					}
					
					
					
					
					
					if ("deliveredQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetDeliveredQuantity(value);
					}
					
					
					
					
					
					if ("receivedQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetReceivedQuantity(value);
					}
					
					
					
					
					
					if ("deliveryAddrId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryAddrId(value);
					}
					
					
					
					
					
					if ("deptId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeptId(value);
					}
					
					
					
					
					
					if ("sourceFileUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSourceFileUrl(value);
					}
					
					
					
					
					
					if ("resultFileUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultFileUrl(value);
					}
					
					
					
					
					
					if ("isDeleted".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetIsDeleted(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("buyerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerName(value);
					}
					
					
					
					
					
					if ("purchaseType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetPurchaseType(value);
					}
					
					
					
					
					
					if ("deptName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeptName(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("approvalTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApprovalTime(value);
					}
					
					
					
					
					
					if ("currency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrency(value);
					}
					
					
					
					
					
					if ("returnAddrId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnAddrId(value);
					}
					
					
					
					
					
					if ("bizLinkerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerId(value);
					}
					
					
					
					
					
					if ("bizLinkerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerName(value);
					}
					
					
					
					
					
					if ("bizLinkerDeptId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerDeptId(value);
					}
					
					
					
					
					
					if ("bizLinkerDeptName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerDeptName(value);
					}
					
					
					
					
					
					if ("approvalRole".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApprovalRole(value);
					}
					
					
					
					
					
					if ("approvalRoleName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApprovalRoleName(value);
					}
					
					
					
					
					
					if ("skipFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSkipFlag(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("isQuota".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsQuota(value);
					}
					
					
					
					
					
					if ("cooperationMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetCooperationMode(value);
					}
					
					
					
					
					
					if ("estimateArrivalTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEstimateArrivalTime(value);
					}
					
					
					
					
					
					if ("isSupplement".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsSupplement(value);
					}
					
					
					
					
					
					if ("goodsType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetGoodsType(value);
					}
					
					
					
					
					
					if ("distributableGoodsTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetDistributableGoodsTime(value);
					}
					
					
					
					
					
					if ("source".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSource(value);
					}
					
					
					
					
					
					if ("settlementMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSettlementMode(value);
					}
					
					
					
					
					
					if ("deduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetDeduction(value);
					}
					
					
					
					
					
					if ("buyerGroupCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerGroupCode(value);
					}
					
					
					
					
					
					if ("buyerGroupName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerGroupName(value);
					}
					
					
					
					
					
					if ("rfidTemplateFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetRfidTemplateFlag(value);
					}
					
					
					
					
					
					if ("vendorIntroduceDept".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorIntroduceDept(value);
					}
					
					
					
					
					
					if ("notDistributedProdInfoUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNotDistributedProdInfoUrl(value);
					}
					
					
					
					
					
					if ("totalAmountCny".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTotalAmountCny(value);
					}
					
					
					
					
					
					if ("goodsChannel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsChannel(value);
					}
					
					
					
					
					
					if ("refundNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefundNo(value);
					}
					
					
					
					
					
					if ("totalReceivedAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTotalReceivedAmount(value);
					}
					
					
					
					
					
					if ("allDisabilityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAllDisabilityLevel(value);
					}
					
					
					
					
					
					if ("creatorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatorName(value);
					}
					
					
					
					
					
					if ("goodsProps".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetGoodsProps(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(PurchaseOrderModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
			}
			
			
			if(structs.GetBatchNo() != null) {
				
				oprot.WriteFieldBegin("batchNo");
				oprot.WriteString(structs.GetBatchNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("batchNo can not be null!");
			}
			
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("companyCode can not be null!");
			}
			
			
			if(structs.GetPurchaseNo() != null) {
				
				oprot.WriteFieldBegin("purchaseNo");
				oprot.WriteString(structs.GetPurchaseNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseNo can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetApprovalStatus() != null) {
				
				oprot.WriteFieldBegin("approvalStatus");
				oprot.WriteByte((byte)structs.GetApprovalStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("approvalStatus can not be null!");
			}
			
			
			if(structs.GetDeliveryStatus() != null) {
				
				oprot.WriteFieldBegin("deliveryStatus");
				oprot.WriteByte((byte)structs.GetDeliveryStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("deliveryStatus can not be null!");
			}
			
			
			if(structs.GetBuyerId() != null) {
				
				oprot.WriteFieldBegin("buyerId");
				oprot.WriteString(structs.GetBuyerId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("buyerId can not be null!");
			}
			
			
			if(structs.GetStockProps() != null) {
				
				oprot.WriteFieldBegin("stockProps");
				oprot.WriteByte((byte)structs.GetStockProps()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("stockProps can not be null!");
			}
			
			
			if(structs.GetDeliveryWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliveryWarehouse");
				oprot.WriteString(structs.GetDeliveryWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("deliveryWarehouse can not be null!");
			}
			
			
			if(structs.GetDisabilityLevel() != null) {
				
				oprot.WriteFieldBegin("disabilityLevel");
				oprot.WriteString(structs.GetDisabilityLevel());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("disabilityLevel can not be null!");
			}
			
			
			if(structs.GetPurchaseQuantity() != null) {
				
				oprot.WriteFieldBegin("purchaseQuantity");
				oprot.WriteI32((int)structs.GetPurchaseQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseQuantity can not be null!");
			}
			
			
			if(structs.GetTotalAmount() != null) {
				
				oprot.WriteFieldBegin("totalAmount");
				oprot.WriteDouble((double)structs.GetTotalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("totalAmount can not be null!");
			}
			
			
			if(structs.GetHoldQuantity() != null) {
				
				oprot.WriteFieldBegin("holdQuantity");
				oprot.WriteI32((int)structs.GetHoldQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("holdQuantity can not be null!");
			}
			
			
			if(structs.GetDeliveredQuantity() != null) {
				
				oprot.WriteFieldBegin("deliveredQuantity");
				oprot.WriteI32((int)structs.GetDeliveredQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("deliveredQuantity can not be null!");
			}
			
			
			if(structs.GetReceivedQuantity() != null) {
				
				oprot.WriteFieldBegin("receivedQuantity");
				oprot.WriteI32((int)structs.GetReceivedQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("receivedQuantity can not be null!");
			}
			
			
			if(structs.GetDeliveryAddrId() != null) {
				
				oprot.WriteFieldBegin("deliveryAddrId");
				oprot.WriteString(structs.GetDeliveryAddrId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeptId() != null) {
				
				oprot.WriteFieldBegin("deptId");
				oprot.WriteString(structs.GetDeptId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("deptId can not be null!");
			}
			
			
			if(structs.GetSourceFileUrl() != null) {
				
				oprot.WriteFieldBegin("sourceFileUrl");
				oprot.WriteString(structs.GetSourceFileUrl());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sourceFileUrl can not be null!");
			}
			
			
			if(structs.GetResultFileUrl() != null) {
				
				oprot.WriteFieldBegin("resultFileUrl");
				oprot.WriteString(structs.GetResultFileUrl());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("resultFileUrl can not be null!");
			}
			
			
			if(structs.GetIsDeleted() != null) {
				
				oprot.WriteFieldBegin("isDeleted");
				oprot.WriteByte((byte)structs.GetIsDeleted()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isDeleted can not be null!");
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("createTime can not be null!");
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("updateTime can not be null!");
			}
			
			
			if(structs.GetBuyerName() != null) {
				
				oprot.WriteFieldBegin("buyerName");
				oprot.WriteString(structs.GetBuyerName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("buyerName can not be null!");
			}
			
			
			if(structs.GetPurchaseType() != null) {
				
				oprot.WriteFieldBegin("purchaseType");
				oprot.WriteByte((byte)structs.GetPurchaseType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseType can not be null!");
			}
			
			
			if(structs.GetDeptName() != null) {
				
				oprot.WriteFieldBegin("deptName");
				oprot.WriteString(structs.GetDeptName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("deptName can not be null!");
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendorCode can not be null!");
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendorName can not be null!");
			}
			
			
			if(structs.GetApprovalTime() != null) {
				
				oprot.WriteFieldBegin("approvalTime");
				oprot.WriteString(structs.GetApprovalTime());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("approvalTime can not be null!");
			}
			
			
			if(structs.GetCurrency() != null) {
				
				oprot.WriteFieldBegin("currency");
				oprot.WriteString(structs.GetCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnAddrId() != null) {
				
				oprot.WriteFieldBegin("returnAddrId");
				oprot.WriteString(structs.GetReturnAddrId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerId() != null) {
				
				oprot.WriteFieldBegin("bizLinkerId");
				oprot.WriteString(structs.GetBizLinkerId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerName() != null) {
				
				oprot.WriteFieldBegin("bizLinkerName");
				oprot.WriteString(structs.GetBizLinkerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerDeptId() != null) {
				
				oprot.WriteFieldBegin("bizLinkerDeptId");
				oprot.WriteString(structs.GetBizLinkerDeptId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerDeptName() != null) {
				
				oprot.WriteFieldBegin("bizLinkerDeptName");
				oprot.WriteString(structs.GetBizLinkerDeptName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApprovalRole() != null) {
				
				oprot.WriteFieldBegin("approvalRole");
				oprot.WriteString(structs.GetApprovalRole());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApprovalRoleName() != null) {
				
				oprot.WriteFieldBegin("approvalRoleName");
				oprot.WriteString(structs.GetApprovalRoleName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkipFlag() != null) {
				
				oprot.WriteFieldBegin("skipFlag");
				oprot.WriteByte((byte)structs.GetSkipFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsQuota() != null) {
				
				oprot.WriteFieldBegin("isQuota");
				oprot.WriteByte((byte)structs.GetIsQuota()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperationMode() != null) {
				
				oprot.WriteFieldBegin("cooperationMode");
				oprot.WriteByte((byte)structs.GetCooperationMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEstimateArrivalTime() != null) {
				
				oprot.WriteFieldBegin("estimateArrivalTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEstimateArrivalTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSupplement() != null) {
				
				oprot.WriteFieldBegin("isSupplement");
				oprot.WriteByte((byte)structs.GetIsSupplement()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsType() != null) {
				
				oprot.WriteFieldBegin("goodsType");
				oprot.WriteByte((byte)structs.GetGoodsType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistributableGoodsTime() != null) {
				
				oprot.WriteFieldBegin("distributableGoodsTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDistributableGoodsTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSource() != null) {
				
				oprot.WriteFieldBegin("source");
				oprot.WriteString(structs.GetSource());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettlementMode() != null) {
				
				oprot.WriteFieldBegin("settlementMode");
				oprot.WriteByte((byte)structs.GetSettlementMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeduction() != null) {
				
				oprot.WriteFieldBegin("deduction");
				oprot.WriteDouble((double)structs.GetDeduction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerGroupCode() != null) {
				
				oprot.WriteFieldBegin("buyerGroupCode");
				oprot.WriteString(structs.GetBuyerGroupCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerGroupName() != null) {
				
				oprot.WriteFieldBegin("buyerGroupName");
				oprot.WriteString(structs.GetBuyerGroupName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRfidTemplateFlag() != null) {
				
				oprot.WriteFieldBegin("rfidTemplateFlag");
				oprot.WriteByte((byte)structs.GetRfidTemplateFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorIntroduceDept() != null) {
				
				oprot.WriteFieldBegin("vendorIntroduceDept");
				oprot.WriteString(structs.GetVendorIntroduceDept());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNotDistributedProdInfoUrl() != null) {
				
				oprot.WriteFieldBegin("notDistributedProdInfoUrl");
				oprot.WriteString(structs.GetNotDistributedProdInfoUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalAmountCny() != null) {
				
				oprot.WriteFieldBegin("totalAmountCny");
				oprot.WriteDouble((double)structs.GetTotalAmountCny());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsChannel() != null) {
				
				oprot.WriteFieldBegin("goodsChannel");
				oprot.WriteString(structs.GetGoodsChannel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefundNo() != null) {
				
				oprot.WriteFieldBegin("refundNo");
				oprot.WriteString(structs.GetRefundNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalReceivedAmount() != null) {
				
				oprot.WriteFieldBegin("totalReceivedAmount");
				oprot.WriteDouble((double)structs.GetTotalReceivedAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAllDisabilityLevel() != null) {
				
				oprot.WriteFieldBegin("allDisabilityLevel");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetAllDisabilityLevel()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatorName() != null) {
				
				oprot.WriteFieldBegin("creatorName");
				oprot.WriteString(structs.GetCreatorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsProps() != null) {
				
				oprot.WriteFieldBegin("goodsProps");
				oprot.WriteByte((byte)structs.GetGoodsProps()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrderModel bean){
			
			
		}
		
	}
	
}