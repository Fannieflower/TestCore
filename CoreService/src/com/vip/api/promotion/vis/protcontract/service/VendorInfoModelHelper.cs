using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class VendorInfoModelHelper : TBeanSerializer<VendorInfoModel>
	{
		
		public static VendorInfoModelHelper OBJ = new VendorInfoModelHelper();
		
		public static VendorInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VendorInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("protNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProtNo(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("isValid".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsValid(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("contractDimension".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetContractDimension(value);
					}
					
					
					
					
					
					if ("activityList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel elem0;
								
								elem0 = new com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel();
								com.vip.api.promotion.vis.protcontract.service.ActivityInfoModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActivityList(value);
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
		
		
		public void Write(VendorInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProtNo() != null) {
				
				oprot.WriteFieldBegin("protNo");
				oprot.WriteString(structs.GetProtNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsValid() != null) {
				
				oprot.WriteFieldBegin("isValid");
				oprot.WriteByte((byte)structs.GetIsValid()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteByte((byte)structs.GetBusinessType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractDimension() != null) {
				
				oprot.WriteFieldBegin("contractDimension");
				oprot.WriteByte((byte)structs.GetContractDimension()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityList() != null) {
				
				oprot.WriteFieldBegin("activityList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel _item0 in structs.GetActivityList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.ActivityInfoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VendorInfoModel bean){
			
			
		}
		
	}
	
}