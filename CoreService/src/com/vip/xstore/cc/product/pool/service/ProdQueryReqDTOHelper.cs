using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	public class ProdQueryReqDTOHelper : TBeanSerializer<ProdQueryReqDTO>
	{
		
		public static ProdQueryReqDTOHelper OBJ = new ProdQueryReqDTOHelper();
		
		public static ProdQueryReqDTOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdQueryReqDTO structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("queryItems".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.product.pool.service.QueryItem> value;
						
						value = new List<com.vip.xstore.cc.product.pool.service.QueryItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.product.pool.service.QueryItem elem0;
								
								elem0 = new com.vip.xstore.cc.product.pool.service.QueryItem();
								com.vip.xstore.cc.product.pool.service.QueryItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetQueryItems(value);
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
		
		
		public void Write(ProdQueryReqDTO structs, Protocol oprot){
			
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
			
			
			if(structs.GetQueryItems() != null) {
				
				oprot.WriteFieldBegin("queryItems");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.product.pool.service.QueryItem _item0 in structs.GetQueryItems()){
					
					
					com.vip.xstore.cc.product.pool.service.QueryItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("queryItems can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdQueryReqDTO bean){
			
			
		}
		
	}
	
}