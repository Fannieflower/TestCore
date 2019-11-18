using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class QueryMyApprovedPoReqHelper : TBeanSerializer<QueryMyApprovedPoReq>
	{
		
		public static QueryMyApprovedPoReqHelper OBJ = new QueryMyApprovedPoReqHelper();
		
		public static QueryMyApprovedPoReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryMyApprovedPoReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("dealType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetDealType(value);
					}
					
					
					
					
					
					if ("currentUserId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrentUserId(value);
					}
					
					
					
					
					
					if ("queryNo".Equals(schemeField.Trim())){
						
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
						
						structs.SetQueryNo(value);
					}
					
					
					
					
					
					if ("queryType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetQueryType(value);
					}
					
					
					
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("deliveryStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetDeliveryStatus(value);
					}
					
					
					
					
					
					if ("stockProps".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStockProps(value);
					}
					
					
					
					
					
					if ("deliveryWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryWarehouse(value);
					}
					
					
					
					
					
					if ("createTimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTimeStart(value);
					}
					
					
					
					
					
					if ("buyerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerId(value);
					}
					
					
					
					
					
					if ("createTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTimeEnd(value);
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
					
					
					
					
					
					if ("purchaseType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPurchaseType(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("goodsType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetGoodsType(value);
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
		
		
		public void Write(QueryMyApprovedPoReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDealType() != null) {
				
				oprot.WriteFieldBegin("dealType");
				oprot.WriteByte((byte)structs.GetDealType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dealType can not be null!");
			}
			
			
			if(structs.GetCurrentUserId() != null) {
				
				oprot.WriteFieldBegin("currentUserId");
				oprot.WriteString(structs.GetCurrentUserId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("currentUserId can not be null!");
			}
			
			
			if(structs.GetQueryNo() != null) {
				
				oprot.WriteFieldBegin("queryNo");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetQueryNo()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("queryNo can not be null!");
			}
			
			
			if(structs.GetQueryType() != null) {
				
				oprot.WriteFieldBegin("queryType");
				oprot.WriteByte((byte)structs.GetQueryType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("queryType can not be null!");
			}
			
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryStatus() != null) {
				
				oprot.WriteFieldBegin("deliveryStatus");
				oprot.WriteByte((byte)structs.GetDeliveryStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStockProps() != null) {
				
				oprot.WriteFieldBegin("stockProps");
				oprot.WriteByte((byte)structs.GetStockProps()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliveryWarehouse");
				oprot.WriteString(structs.GetDeliveryWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTimeStart() != null) {
				
				oprot.WriteFieldBegin("createTimeStart");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTimeStart())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerId() != null) {
				
				oprot.WriteFieldBegin("buyerId");
				oprot.WriteString(structs.GetBuyerId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTimeEnd() != null) {
				
				oprot.WriteFieldBegin("createTimeEnd");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTimeEnd())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseType() != null) {
				
				oprot.WriteFieldBegin("purchaseType");
				oprot.WriteByte((byte)structs.GetPurchaseType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsType() != null) {
				
				oprot.WriteFieldBegin("goodsType");
				oprot.WriteByte((byte)structs.GetGoodsType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryMyApprovedPoReq bean){
			
			
		}
		
	}
	
}