using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	public class ProdValidateReqDTOHelper : TBeanSerializer<ProdValidateReqDTO>
	{
		
		public static ProdValidateReqDTOHelper OBJ = new ProdValidateReqDTOHelper();
		
		public static ProdValidateReqDTOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdValidateReqDTO structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("verificationItems".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.product.pool.service.VerificationItem> value;
						
						value = new List<com.vip.xstore.cc.product.pool.service.VerificationItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.product.pool.service.VerificationItem elem0;
								
								elem0 = new com.vip.xstore.cc.product.pool.service.VerificationItem();
								com.vip.xstore.cc.product.pool.service.VerificationItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetVerificationItems(value);
					}
					
					
					
					
					
					if ("isQuota".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsQuota(value);
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
		
		
		public void Write(ProdValidateReqDTO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("companyCode can not be null!");
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteI32((int)structs.GetBusinessType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("businessType can not be null!");
			}
			
			
			if(structs.GetVerificationItems() != null) {
				
				oprot.WriteFieldBegin("verificationItems");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.product.pool.service.VerificationItem _item0 in structs.GetVerificationItems()){
					
					
					com.vip.xstore.cc.product.pool.service.VerificationItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("verificationItems can not be null!");
			}
			
			
			if(structs.GetIsQuota() != null) {
				
				oprot.WriteFieldBegin("isQuota");
				oprot.WriteByte((byte)structs.GetIsQuota()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdValidateReqDTO bean){
			
			
		}
		
	}
	
}