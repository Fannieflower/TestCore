using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	public class OutWmsOrderInfoHelper : TBeanSerializer<OutWmsOrderInfo>
	{
		
		public static OutWmsOrderInfoHelper OBJ = new OutWmsOrderInfoHelper();
		
		public static OutWmsOrderInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OutWmsOrderInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("saleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSaleType(value);
					}
					
					
					
					
					
					if ("isTmsProvideTransportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetIsTmsProvideTransportNo(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("transportDay".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportDay(value);
					}
					
					
					
					
					
					if ("batchNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBatchNumber(value);
					}
					
					
					
					
					
					if ("ladingBillNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLadingBillNumber(value);
					}
					
					
					
					
					
					if ("subLadingBillNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubLadingBillNumber(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("buyer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("province".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvince(value);
					}
					
					
					
					
					
					if ("city".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity(value);
					}
					
					
					
					
					
					if ("district".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDistrict(value);
					}
					
					
					
					
					
					if ("street".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStreet(value);
					}
					
					
					
					
					
					if ("buyerIdcard".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerIdcard(value);
					}
					
					
					
					
					
					if ("tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTel(value);
					}
					
					
					
					
					
					if ("mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobile(value);
					}
					
					
					
					
					
					if ("totalMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTotalMoney(value);
					}
					
					
					
					
					
					if ("payMount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetPayMount(value);
					}
					
					
					
					
					
					if ("favourableMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetFavourableMoney(value);
					}
					
					
					
					
					
					if ("carriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetCarriage(value);
					}
					
					
					
					
					
					if ("customCarriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetCustomCarriage(value);
					}
					
					
					
					
					
					if ("taxFee".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTaxFee(value);
					}
					
					
					
					
					
					if ("payMoneyType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayMoneyType(value);
					}
					
					
					
					
					
					if ("tradeNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTradeNumber(value);
					}
					
					
					
					
					
					if ("payTypeNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayTypeNumber(value);
					}
					
					
					
					
					
					if ("enterpriseCertCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEnterpriseCertCode(value);
					}
					
					
					
					
					
					if ("carriersName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarriersName(value);
					}
					
					
					
					
					
					if ("carrierPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointCode(value);
					}
					
					
					
					
					
					if ("carrierPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointName(value);
					}
					
					
					
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("originCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginCode(value);
					}
					
					
					
					
					
					if ("destinationCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestinationCode(value);
					}
					
					
					
					
					
					if ("templateCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTemplateCode(value);
					}
					
					
					
					
					
					if ("pickCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPickCode(value);
					}
					
					
					
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("customsCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomsCode(value);
					}
					
					
					
					
					
					if ("chinaFreightForwarding".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChinaFreightForwarding(value);
					}
					
					
					
					
					
					if ("globalFreightForwarding".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGlobalFreightForwarding(value);
					}
					
					
					
					
					
					if ("customsClearanceMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomsClearanceMode(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("orderDetail".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.sce.vlg.osp.wms.service.OutWmsOrderDetail> value;
						
						value = new List<com.vip.sce.vlg.osp.wms.service.OutWmsOrderDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.sce.vlg.osp.wms.service.OutWmsOrderDetail elem0;
								
								elem0 = new com.vip.sce.vlg.osp.wms.service.OutWmsOrderDetail();
								com.vip.sce.vlg.osp.wms.service.OutWmsOrderDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderDetail(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("channel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChannel(value);
					}
					
					
					
					
					
					if ("userDef1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDef1(value);
					}
					
					
					
					
					
					if ("userDef2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDef2(value);
					}
					
					
					
					
					
					if ("userDef3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDef3(value);
					}
					
					
					
					
					
					if ("userDef4".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDef4(value);
					}
					
					
					
					
					
					if ("userDef5".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUserDef5(value);
					}
					
					
					
					
					
					if ("userDef6".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUserDef6(value);
					}
					
					
					
					
					
					if ("userDef7".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDef7(value);
					}
					
					
					
					
					
					if ("userDef8".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDef8(value);
					}
					
					
					
					
					
					if ("unloadPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUnloadPointCode(value);
					}
					
					
					
					
					
					if ("unloadPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUnloadPointName(value);
					}
					
					
					
					
					
					if ("orderDeliveryBatch".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetOrderDeliveryBatch(value);
					}
					
					
					
					
					
					if ("pickupGoodsTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPickupGoodsTime(value);
					}
					
					
					
					
					
					if ("transportPrd".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportPrd(value);
					}
					
					
					
					
					
					if ("boxId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBoxId(value);
					}
					
					
					
					
					
					if ("payType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayType(value);
					}
					
					
					
					
					
					if ("transportType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportType(value);
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
		
		
		public void Write(OutWmsOrderInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderId() != null) {
				
				oprot.WriteFieldBegin("orderId");
				oprot.WriteString(structs.GetOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderId can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetSaleType() != null) {
				
				oprot.WriteFieldBegin("saleType");
				oprot.WriteString(structs.GetSaleType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("saleType can not be null!");
			}
			
			
			if(structs.GetIsTmsProvideTransportNo() != null) {
				
				oprot.WriteFieldBegin("isTmsProvideTransportNo");
				oprot.WriteI32((int)structs.GetIsTmsProvideTransportNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isTmsProvideTransportNo can not be null!");
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteString(structs.GetCreateTime());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("createTime can not be null!");
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse can not be null!");
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportDay() != null) {
				
				oprot.WriteFieldBegin("transportDay");
				oprot.WriteString(structs.GetTransportDay());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBatchNumber() != null) {
				
				oprot.WriteFieldBegin("batchNumber");
				oprot.WriteString(structs.GetBatchNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLadingBillNumber() != null) {
				
				oprot.WriteFieldBegin("ladingBillNumber");
				oprot.WriteString(structs.GetLadingBillNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubLadingBillNumber() != null) {
				
				oprot.WriteFieldBegin("subLadingBillNumber");
				oprot.WriteString(structs.GetSubLadingBillNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI32((int)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer() != null) {
				
				oprot.WriteFieldBegin("buyer");
				oprot.WriteString(structs.GetBuyer());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("buyer can not be null!");
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				oprot.WriteString(structs.GetAddress());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("address can not be null!");
			}
			
			
			if(structs.GetProvince() != null) {
				
				oprot.WriteFieldBegin("province");
				oprot.WriteString(structs.GetProvince());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("province can not be null!");
			}
			
			
			if(structs.GetCity() != null) {
				
				oprot.WriteFieldBegin("city");
				oprot.WriteString(structs.GetCity());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("city can not be null!");
			}
			
			
			if(structs.GetDistrict() != null) {
				
				oprot.WriteFieldBegin("district");
				oprot.WriteString(structs.GetDistrict());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStreet() != null) {
				
				oprot.WriteFieldBegin("street");
				oprot.WriteString(structs.GetStreet());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerIdcard() != null) {
				
				oprot.WriteFieldBegin("buyerIdcard");
				oprot.WriteString(structs.GetBuyerIdcard());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("buyerIdcard can not be null!");
			}
			
			
			if(structs.GetTel() != null) {
				
				oprot.WriteFieldBegin("tel");
				oprot.WriteString(structs.GetTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobile() != null) {
				
				oprot.WriteFieldBegin("mobile");
				oprot.WriteString(structs.GetMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalMoney() != null) {
				
				oprot.WriteFieldBegin("totalMoney");
				oprot.WriteDouble((double)structs.GetTotalMoney());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("totalMoney can not be null!");
			}
			
			
			if(structs.GetPayMount() != null) {
				
				oprot.WriteFieldBegin("payMount");
				oprot.WriteDouble((double)structs.GetPayMount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payMount can not be null!");
			}
			
			
			if(structs.GetFavourableMoney() != null) {
				
				oprot.WriteFieldBegin("favourableMoney");
				oprot.WriteDouble((double)structs.GetFavourableMoney());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("favourableMoney can not be null!");
			}
			
			
			if(structs.GetCarriage() != null) {
				
				oprot.WriteFieldBegin("carriage");
				oprot.WriteDouble((double)structs.GetCarriage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carriage can not be null!");
			}
			
			
			if(structs.GetCustomCarriage() != null) {
				
				oprot.WriteFieldBegin("customCarriage");
				oprot.WriteDouble((double)structs.GetCustomCarriage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("customCarriage can not be null!");
			}
			
			
			if(structs.GetTaxFee() != null) {
				
				oprot.WriteFieldBegin("taxFee");
				oprot.WriteDouble((double)structs.GetTaxFee());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("taxFee can not be null!");
			}
			
			
			if(structs.GetPayMoneyType() != null) {
				
				oprot.WriteFieldBegin("payMoneyType");
				oprot.WriteString(structs.GetPayMoneyType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payMoneyType can not be null!");
			}
			
			
			if(structs.GetTradeNumber() != null) {
				
				oprot.WriteFieldBegin("tradeNumber");
				oprot.WriteString(structs.GetTradeNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayTypeNumber() != null) {
				
				oprot.WriteFieldBegin("payTypeNumber");
				oprot.WriteString(structs.GetPayTypeNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnterpriseCertCode() != null) {
				
				oprot.WriteFieldBegin("enterpriseCertCode");
				oprot.WriteString(structs.GetEnterpriseCertCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarriersName() != null) {
				
				oprot.WriteFieldBegin("carriersName");
				oprot.WriteString(structs.GetCarriersName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointCode() != null) {
				
				oprot.WriteFieldBegin("carrierPointCode");
				oprot.WriteString(structs.GetCarrierPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointName() != null) {
				
				oprot.WriteFieldBegin("carrierPointName");
				oprot.WriteString(structs.GetCarrierPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transportNo can not be null!");
			}
			
			
			if(structs.GetOriginCode() != null) {
				
				oprot.WriteFieldBegin("originCode");
				oprot.WriteString(structs.GetOriginCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestinationCode() != null) {
				
				oprot.WriteFieldBegin("destinationCode");
				oprot.WriteString(structs.GetDestinationCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTemplateCode() != null) {
				
				oprot.WriteFieldBegin("templateCode");
				oprot.WriteString(structs.GetTemplateCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPickCode() != null) {
				
				oprot.WriteFieldBegin("pickCode");
				oprot.WriteString(structs.GetPickCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomsCode() != null) {
				
				oprot.WriteFieldBegin("customsCode");
				oprot.WriteString(structs.GetCustomsCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("customsCode can not be null!");
			}
			
			
			if(structs.GetChinaFreightForwarding() != null) {
				
				oprot.WriteFieldBegin("chinaFreightForwarding");
				oprot.WriteString(structs.GetChinaFreightForwarding());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("chinaFreightForwarding can not be null!");
			}
			
			
			if(structs.GetGlobalFreightForwarding() != null) {
				
				oprot.WriteFieldBegin("globalFreightForwarding");
				oprot.WriteString(structs.GetGlobalFreightForwarding());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomsClearanceMode() != null) {
				
				oprot.WriteFieldBegin("customsClearanceMode");
				oprot.WriteString(structs.GetCustomsClearanceMode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("customsClearanceMode can not be null!");
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteString(structs.GetUpdateTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetOrderDetail() != null) {
				
				oprot.WriteFieldBegin("orderDetail");
				
				oprot.WriteListBegin();
				foreach(com.vip.sce.vlg.osp.wms.service.OutWmsOrderDetail _item0 in structs.GetOrderDetail()){
					
					
					com.vip.sce.vlg.osp.wms.service.OutWmsOrderDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannel() != null) {
				
				oprot.WriteFieldBegin("channel");
				oprot.WriteString(structs.GetChannel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef1() != null) {
				
				oprot.WriteFieldBegin("userDef1");
				oprot.WriteString(structs.GetUserDef1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef2() != null) {
				
				oprot.WriteFieldBegin("userDef2");
				oprot.WriteString(structs.GetUserDef2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef3() != null) {
				
				oprot.WriteFieldBegin("userDef3");
				oprot.WriteString(structs.GetUserDef3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef4() != null) {
				
				oprot.WriteFieldBegin("userDef4");
				oprot.WriteString(structs.GetUserDef4());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef5() != null) {
				
				oprot.WriteFieldBegin("userDef5");
				oprot.WriteI64((long)structs.GetUserDef5()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef6() != null) {
				
				oprot.WriteFieldBegin("userDef6");
				oprot.WriteI64((long)structs.GetUserDef6()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef7() != null) {
				
				oprot.WriteFieldBegin("userDef7");
				oprot.WriteString(structs.GetUserDef7());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDef8() != null) {
				
				oprot.WriteFieldBegin("userDef8");
				oprot.WriteString(structs.GetUserDef8());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUnloadPointCode() != null) {
				
				oprot.WriteFieldBegin("unloadPointCode");
				oprot.WriteString(structs.GetUnloadPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUnloadPointName() != null) {
				
				oprot.WriteFieldBegin("unloadPointName");
				oprot.WriteString(structs.GetUnloadPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderDeliveryBatch() != null) {
				
				oprot.WriteFieldBegin("orderDeliveryBatch");
				oprot.WriteByte((byte)structs.GetOrderDeliveryBatch()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPickupGoodsTime() != null) {
				
				oprot.WriteFieldBegin("pickupGoodsTime");
				oprot.WriteString(structs.GetPickupGoodsTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportPrd() != null) {
				
				oprot.WriteFieldBegin("transportPrd");
				oprot.WriteString(structs.GetTransportPrd());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBoxId() != null) {
				
				oprot.WriteFieldBegin("boxId");
				oprot.WriteString(structs.GetBoxId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayType() != null) {
				
				oprot.WriteFieldBegin("payType");
				oprot.WriteString(structs.GetPayType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportType() != null) {
				
				oprot.WriteFieldBegin("transportType");
				oprot.WriteString(structs.GetTransportType());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OutWmsOrderInfo bean){
			
			
		}
		
	}
	
}