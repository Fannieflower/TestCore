using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.imp.otd.otdapi.service{
	
	
	
	public class VopPageModelHelper : TBeanSerializer<VopPageModel>
	{
		
		public static VopPageModelHelper OBJ = new VopPageModelHelper();
		
		public static VopPageModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VopPageModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("page_index".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetPage_index(value);
					}
					
					
					
					
					
					if ("page_size".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetPage_size(value);
					}
					
					
					
					
					
					if ("total_count".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetTotal_count(value);
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
		
		
		public void Write(VopPageModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPage_index() != null) {
				
				oprot.WriteFieldBegin("page_index");
				oprot.WriteI64((long)structs.GetPage_index()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page_index can not be null!");
			}
			
			
			if(structs.GetPage_size() != null) {
				
				oprot.WriteFieldBegin("page_size");
				oprot.WriteI64((long)structs.GetPage_size()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page_size can not be null!");
			}
			
			
			if(structs.GetTotal_count() != null) {
				
				oprot.WriteFieldBegin("total_count");
				oprot.WriteI64((long)structs.GetTotal_count()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total_count can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VopPageModel bean){
			
			
		}
		
	}
	
}