using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class PurchaseOrderUpdateRequestHelper : TBeanSerializer<PurchaseOrderUpdateRequest>
	{
		
		public static PurchaseOrderUpdateRequestHelper OBJ = new PurchaseOrderUpdateRequestHelper();
		
		public static PurchaseOrderUpdateRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrderUpdateRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchaseNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseNo(value);
					}
					
					
					
					
					
					if ("uploadedFilePath".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUploadedFilePath(value);
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
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
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
					
					
					
					
					
					if ("estimateArrivalTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEstimateArrivalTime(value);
					}
					
					
					
					
					
					if ("purchaseLabel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseLabel(value);
					}
					
					
					
					
					
					if ("skipFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSkipFlag(value);
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
		
		
		public void Write(PurchaseOrderUpdateRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchaseNo() != null) {
				
				oprot.WriteFieldBegin("purchaseNo");
				oprot.WriteString(structs.GetPurchaseNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUploadedFilePath() != null) {
				
				oprot.WriteFieldBegin("uploadedFilePath");
				oprot.WriteString(structs.GetUploadedFilePath());
				
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
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
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
			
			
			if(structs.GetEstimateArrivalTime() != null) {
				
				oprot.WriteFieldBegin("estimateArrivalTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEstimateArrivalTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseLabel() != null) {
				
				oprot.WriteFieldBegin("purchaseLabel");
				oprot.WriteString(structs.GetPurchaseLabel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkipFlag() != null) {
				
				oprot.WriteFieldBegin("skipFlag");
				oprot.WriteByte((byte)structs.GetSkipFlag()); 
				
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
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrderUpdateRequest bean){
			
			
		}
		
	}
	
}