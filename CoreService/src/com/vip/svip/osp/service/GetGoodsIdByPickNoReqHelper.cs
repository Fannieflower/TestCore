using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GetGoodsIdByPickNoReqHelper : TBeanSerializer<GetGoodsIdByPickNoReq>
	{
		
		public static GetGoodsIdByPickNoReqHelper OBJ = new GetGoodsIdByPickNoReqHelper();
		
		public static GetGoodsIdByPickNoReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetGoodsIdByPickNoReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pickNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetPickNo(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
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
		
		
		public void Write(GetGoodsIdByPickNoReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPickNo() != null) {
				
				oprot.WriteFieldBegin("pickNo");
				oprot.WriteI64((long)structs.GetPickNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pickNo can not be null!");
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetGoodsIdByPickNoReq bean){
			
			
		}
		
	}
	
}