using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.cache{
	
	
	
	public class RefreshCacheParamHelper : TBeanSerializer<RefreshCacheParam>
	{
		
		public static RefreshCacheParamHelper OBJ = new RefreshCacheParamHelper();
		
		public static RefreshCacheParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefreshCacheParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("createdOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedOffice(value);
					}
					
					
					
					
					
					if ("custRegion".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustRegion(value);
					}
					
					
					
					
					
					if ("custTown".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustTown(value);
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
		
		
		public void Write(RefreshCacheParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedOffice() != null) {
				
				oprot.WriteFieldBegin("createdOffice");
				oprot.WriteString(structs.GetCreatedOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustRegion() != null) {
				
				oprot.WriteFieldBegin("custRegion");
				oprot.WriteString(structs.GetCustRegion());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustTown() != null) {
				
				oprot.WriteFieldBegin("custTown");
				oprot.WriteString(structs.GetCustTown());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefreshCacheParam bean){
			
			
		}
		
	}
	
}